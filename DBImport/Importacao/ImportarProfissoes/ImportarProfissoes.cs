using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Api.Engines.Venda.Infra;
using Microsoft.Azure.Documents.Client;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Azure.WebJobs.Host;

namespace Api.Engines.Venda.Importacao.ImportarProfissoes
{
    //1 - Gravar dados do Acumulo de Capital -- Não rola, base grande demais. Import seria muito caro.
    //2 - Gravar dados do Modelo de Proposta
    //3 - Gravar dados do Configuracao Integracao
    //4 - Gravar dados de Profissao
    //5 - Gravar dados de Taxas -- Não é necessário porque quem busca as taxas é o calculo??
    //6 - Gravar dados de Limite Operacional
    //7 - Gravar dados de DeParaEsimSysprev
    public static class ImportarProfissoes
    {
        [FunctionName("ImportarProfissoes")]
        public async static Task<HttpResponseMessage> Run([HttpTrigger(AuthorizationLevel.Function, "get", "post", Route = null)]HttpRequestMessage req,
            [DocumentDB("Venda", "Profissoes", Id = "id", CreateIfNotExists = true)] IAsyncCollector<dynamic> profissoes,
            [DocumentDB("Venda", "Profissoes", Id = "id")] DocumentClient documents,
            TraceWriter log)
        {

            Stopwatch sw = new Stopwatch();
            sw.Start();
            log.Info("Buscando todas as profissões no ESB.Pessoa v1");
            var resultado = ServiceWcf<Mongeral.ESB.Pessoa.Contrato.v1.Operacoes.IPessoaService>.UseSync(pessoa => pessoa.ObterTodasAsProfissoes());
            sw.Stop();
            log.Info($"Terminou de buscar todas as profissões no ESB.Pessoa v1 em {sw.ElapsedMilliseconds}");


            if(resultado.HouveErrosDuranteProcessamento)
            {
                profissoes = null;
                var msg = String.Empty;
                resultado.Mensagens.ForEach(m => msg += " \n " + m);
                return req.CreateErrorResponse(HttpStatusCode.InternalServerError, msg);
            }

            log.Info("Limpando coleção de Profissões.");
            await documents.DeleteDocumentCollectionAsync(UriFactory.CreateDocumentCollectionUri("Venda", "Profissoes"));
            log.Info("Terminou de limpar as profisões.");


            log.Info("Salvando Profissões.");
            var tasks = new List<Task>();
            foreach(var profissao in resultado.Valor)
            {
                tasks.Add(profissoes.AddAsync(new
                {
                    id = profissao.Id.ToString(),
                    profissao.Cbo,
                    profissao.CodigoIr,
                    profissao.CodigosDoSysPrev,
                    profissao.CodigoSysPrev,
                    profissao.Descricao,
                    profissao.ValorMaximoCapitalSegurado
                }));
            }
            Task.WaitAll(tasks.ToArray());
            log.Info("Terminou de salvar Profissões.");

            return req.CreateResponse(HttpStatusCode.OK);
        }
    }
}
