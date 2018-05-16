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
    //1 - Gravar dados do Acumulo de Capital -- N�o rola, base grande demais. Import seria muito caro.
    //2 - Gravar dados do Modelo de Proposta
    //3 - Gravar dados do Configuracao Integracao
    //4 - Gravar dados de Profissao
    //5 - Gravar dados de Taxas -- N�o � necess�rio porque quem busca as taxas � o calculo??
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
            log.Info("Buscando todas as profiss�es no ESB.Pessoa v1");
            var resultado = ServiceWcf<Mongeral.ESB.Pessoa.Contrato.v1.Operacoes.IPessoaService>.UseSync(pessoa => pessoa.ObterTodasAsProfissoes());
            sw.Stop();
            log.Info($"Terminou de buscar todas as profiss�es no ESB.Pessoa v1 em {sw.ElapsedMilliseconds}");


            if(resultado.HouveErrosDuranteProcessamento)
            {
                profissoes = null;
                var msg = String.Empty;
                resultado.Mensagens.ForEach(m => msg += " \n " + m);
                return req.CreateErrorResponse(HttpStatusCode.InternalServerError, msg);
            }

            log.Info("Limpando cole��o de Profiss�es.");
            await documents.DeleteDocumentCollectionAsync(UriFactory.CreateDocumentCollectionUri("Venda", "Profissoes"));
            log.Info("Terminou de limpar as profis�es.");


            log.Info("Salvando Profiss�es.");
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
            log.Info("Terminou de salvar Profiss�es.");

            return req.CreateResponse(HttpStatusCode.OK);
        }
    }
}
