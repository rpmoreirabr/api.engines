using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Api.Engines.Venda.Infra;
using Microsoft.Azure.Documents.Client;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Azure.WebJobs.Host;
using Mongeral.ESB.Produto.Contrato.v2.Dados;

namespace Api.Engines.Venda.SimulacaoIndividual
{
    public static class SimulacaoIndividual
    {
        public class ParametrosSimulacao
        {
            public string Sexo { get; set; }
            public string SexoConjuge { get; set; }
            public DateTime Nascimento { get; set; }
            public string Ocupacao { get; set; }
            public string Estado { get; set; }
            public Decimal Renda { get; set; }
            public short Periodicidade { get; set; }
            public short PrazoDecrescimo { get; set; }
            public short IdadePgtoAntecipado { get; set; }
            public short TempoPrazoAntecipado { get; set; }
            public short PrazoCerto { get; set; }           
            public DateTime NascimentoConj { get; set; }

            public string RelacaoSegurado { get; set; }
        }

        [FunctionName("SimulacaoIndividual")]
        public static HttpResponseMessage Run(
            [HttpTrigger(AuthorizationLevel.Function, "post", Route = "SimulacaoIndividual/{ModeloProposta}/{Documento:long}")]HttpRequestMessage req,
            string ModeloProposta,
            long Documento,           
            [DocumentDB("Venda", "TabelasVenda", Id = "id")] DocumentClient tabelasVenda,            
            [DocumentDB("Venda", "ModelosNegocio", Id = "id")] DocumentClient modelosNegocio,
            [DocumentDB("Venda", "Profissoes", Id = "id")] DocumentClient profissoes,
            TraceWriter log)
        {
            var parametros = PreencherParametros(req);

            var modeloProposta = modelosNegocio.CreateDocumentQuery<Model.ModeloPropostaCompleto>(UriFactory.CreateDocumentCollectionUri("Venda", "ModelosNegocio")
                , $"SELECT VALUE m FROM c JOIN m IN c.Modelos WHERE m.Id = '{ModeloProposta}'")
                .ToList()
                .FirstOrDefault();

            var profissao = profissoes.CreateDocumentQuery<Profissao>(UriFactory.CreateDocumentCollectionUri("Venda", "Profissoes"),
                $"SELECT * FROM c WHERE c.Cbo = '{parametros.Ocupacao}'").ToList().FirstOrDefault();


            var resultado = new ServicoSimulacao().ObterRegrasContratacao(modeloProposta,
                Documento,
                parametros.Nascimento,
                parametros.Sexo == "F" ? Model.Enum.SexoEnum.Feminino : Model.Enum.SexoEnum.Masculino,                
                parametros.Estado,
                profissao,
                parametros.Periodicidade,
                parametros.SexoConjuge == "M" ? Model.Enum.SexoEnum.Masculino : Model.Enum.SexoEnum.Feminino,
                parametros.NascimentoConj,
                parametros.PrazoCerto,
                parametros.TempoPrazoAntecipado,
                parametros.IdadePgtoAntecipado,
                parametros.PrazoDecrescimo,
                String.IsNullOrEmpty(parametros.RelacaoSegurado) ? Model.Enum.TipoRelacaoSegurado.Titular : (Model.Enum.TipoRelacaoSegurado) Enum.Parse(typeof(Model.Enum.TipoRelacaoSegurado), parametros.RelacaoSegurado),                
                parametros.Renda);

            return req.CreateResponse(HttpStatusCode.OK, resultado);
        }

        private static ParametrosSimulacao PreencherParametros(HttpRequestMessage req)
        {
            var sexo = req.GetQueryNameValuePairs()
                .Where(q => q.Key == "sexo")
                .FirstOrDefault().Value;

            var sexoConjuge = req.GetQueryNameValuePairs()
                .Where(q => q.Key == "sexoConj")
                .FirstOrDefault().Value;

            var nascimento = Convert.ToDateTime(req.GetQueryNameValuePairs()
                .Where(q => q.Key == "nascimento")
                .FirstOrDefault().Value);

            var ocupacao = req.GetQueryNameValuePairs()
                .Where(q => q.Key == "ocupacao")
                .FirstOrDefault().Value;

            var estado = req.GetQueryNameValuePairs()
                .Where(q => q.Key == "estado")
                .FirstOrDefault().Value;

            var renda = Convert.ToDecimal(req.GetQueryNameValuePairs()
                .Where(q => q.Key == "renda")
                .FirstOrDefault().Value);

            var periodicidade = Convert.ToInt16(req.GetQueryNameValuePairs()
                .Where(q => q.Key == "periodicidade")
                .FirstOrDefault().Value);

            var prazoDecrescimo = Convert.ToInt16(req.GetQueryNameValuePairs()
                .Where(q => q.Key == "prazoDecrescimo")
                .FirstOrDefault().Value);

            var idadePgtoAntecipado = Convert.ToInt16(req.GetQueryNameValuePairs()
                .Where(q => q.Key == "idadePgtoAntecipado")
                .FirstOrDefault().Value);

            var tempoPrazoAntecipado = Convert.ToInt16(req.GetQueryNameValuePairs()
                .Where(q => q.Key == "tempoPrazoAntecipado")
                .FirstOrDefault().Value);

            var prazoCerto = Convert.ToInt16(req.GetQueryNameValuePairs()
                .Where(q => q.Key == "prazoCerto")
                .FirstOrDefault().Value);        

            var relacaoSegurado = req.GetQueryNameValuePairs()
                .Where(q => q.Key == "relacaoSegurado")
                .FirstOrDefault().Value;

            var nascimentoConj = Convert.ToDateTime(req.GetQueryNameValuePairs()
                .Where(q => q.Key == "nascimentoConj")
                .FirstOrDefault().Value);

            return new ParametrosSimulacao()
            {
                Estado = estado,
                IdadePgtoAntecipado = idadePgtoAntecipado,
                Nascimento = nascimento,
                NascimentoConj = nascimentoConj,
                Ocupacao = ocupacao,
                Periodicidade = periodicidade,
                PrazoCerto = prazoCerto,
                PrazoDecrescimo = prazoDecrescimo,
                Renda = renda,
                Sexo = sexo,
                SexoConjuge = sexoConjuge,
                TempoPrazoAntecipado = tempoPrazoAntecipado,
                RelacaoSegurado = relacaoSegurado
            };
        }
    }
}
