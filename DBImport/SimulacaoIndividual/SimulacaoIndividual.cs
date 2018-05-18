using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using Api.Engines.Venda.SimulacaoIndividual.Contratos.Request;
using Microsoft.Azure.Documents.Client;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Azure.WebJobs.Host;
using Mongeral.ESB.Produto.Contrato.v2.Dados;

namespace Api.Engines.Venda.SimulacaoIndividual
{
    public static class SimulacaoIndividual
    {
        [FunctionName("SimulacaoIndividual")]
        public static HttpResponseMessage Run(
            [HttpTrigger(AuthorizationLevel.Function, "post", Route = "SimulacaoIndividual")]HttpRequestMessage req,
            [DocumentDB("Venda", "ModelosNegocio", Id = "id")] DocumentClient modelosNegocio,
            [DocumentDB("Venda", "Profissoes", Id = "id")] DocumentClient profissoes,
            [DocumentDB("Venda", "Simulacoes")] IAsyncCollector<dynamic> simulacoes,
            TraceWriter log)
        {
            var parametros = PreencherParametros(req);

            var modeloProposta = modelosNegocio.CreateDocumentQuery<Model.ModeloPropostaCompleto>(UriFactory.CreateDocumentCollectionUri("Venda", "ModelosNegocio")
                , $"SELECT VALUE m FROM c JOIN m IN c.Modelos WHERE m.Id = '{parametros.Contratacao.ModeloProposta}'")
                .ToList()
                .FirstOrDefault();

            var profissao = profissoes.CreateDocumentQuery<Profissao>(UriFactory.CreateDocumentCollectionUri("Venda", "Profissoes"),
                $"SELECT * FROM c WHERE c.Cbo = '{parametros.Proponente.Profissao}'").ToList().FirstOrDefault();


            var resultado = new ServicoSimulacao().ObterRegrasContratacao(modeloProposta,
                parametros.Proponente.Documento.GetValueOrDefault(),
                parametros.Proponente.DataNascimento.GetValueOrDefault(),
                parametros.Proponente.Sexo.ToLower() == "feminino" ? Model.Enum.SexoEnum.Feminino : Model.Enum.SexoEnum.Masculino,
                parametros.Proponente.Estado,
                profissao,
                parametros.Contratacao.Parametros.Find(Parametro.IsPeriodicidade)?.Valor ?? 0,
                parametros.Conjuge.Sexo.ToLower() == "masculino" ? Model.Enum.SexoEnum.Masculino : Model.Enum.SexoEnum.Feminino,
                parametros.Conjuge.DataNascimento.GetValueOrDefault(),
                parametros.Contratacao.Parametros.Find(Parametro.IsPrazoCerto)?.Valor ?? 0,
                parametros.Contratacao.Parametros.Find(Parametro.IsTempoPrazoAntecipado)?.Valor ?? 0,
                parametros.Contratacao.Parametros.Find(Parametro.IsIdadePagamentoAntecipado)?.Valor ?? 0,
                parametros.Contratacao.Parametros.Find(Parametro.IsPrazoDecrescimo)?.Valor ?? 0,
                Model.Enum.TipoRelacaoSegurado.Titular,
                parametros.Proponente.Renda.GetValueOrDefault());

            var simulacao = new Contratos.Response.Response()
            {
                Request = parametros,
                Produtos = new List<Contratos.Response.Produto>(resultado.Produtos.Select(p => new Contratos.Response.Produto()
                {
                    Id = p.IdProduto,
                    Descricao = p.Descricao,
                    Obrigatorio = p.Obrigatorio,
                    Coberturas = new List<Contratos.Response.Cobertura>(p.CoberturasLimite.Select(c => new Contratos.Response.Cobertura()
                    {
                        CapitalBase = c.CapitalBase,
                        Causa = c.Causa,
                        Descricao = c.Descricao,
                        Limite = c.Limite,
                        Id = c.IdItemProduto,
                        PremioBase = c.PremioBase,
                        Obrigatorio = c.Obrigatorio,
                        TipoCapitalBase = Enum.GetName(typeof(Model.Enum.TipoCapitalBase), c.TipoCapitalBase),
                        TipoCobertura = c.Tipo?.Descricao,
                        TipoRelacaoSegurado = c.TipoRelacaoSegurado?.Descricao
                    }))
                })),
                TicketMinimo = resultado.TicketMinimo
            };

            simulacoes.AddAsync(simulacao);

            return req.CreateResponse(HttpStatusCode.OK, simulacao);
        }

        private static Request PreencherParametros(HttpRequestMessage req)
        {
            var request = (req.Content.ReadAsAsync(typeof(Request)));
            request.Wait();
            return (Request) request.Result;
        }
    }
}
