//using System;
//using System.Collections.Generic;
//using System.Diagnostics;
//using System.Linq;
//using System.Net;
//using System.Net.Http;
//using System.Threading.Tasks;
//using Api.Engines.Venda.Infra;
//using Microsoft.Azure.Documents.Client;
//using Microsoft.Azure.WebJobs;
//using Microsoft.Azure.WebJobs.Extensions.Http;
//using Microsoft.Azure.WebJobs.Host;
//using Mongeral.ESB.Produto.Contrato.v2.Dados;
//using Mongeral.ESB.Produto.Contrato.v2.Operacoes;

//namespace Api.Engines.Venda.Importacao.ImportarDePara
//{
//    public static class ImportarDePara
//    {
//        [FunctionName("ImportarDePara")]
//        public static async Task<HttpResponseMessage> Run([HttpTrigger(AuthorizationLevel.Function, "get", "post", Route = null)]HttpRequestMessage req, 
//            [DocumentDB("Venda", "DePara", Id = "id", CreateIfNotExists = true)] IAsyncCollector<dynamic> deparas,
//            [DocumentDB("Venda", "DePara", Id = "id")] DocumentClient documents,
//            TraceWriter log)
//        {
//            var cnpjs = Environment.GetEnvironmentVariable("Clientes.Cnpj").Split(',');            

//            Stopwatch sw = new Stopwatch();
//            sw.Start();
//            log.Info("Buscando modelos de proposta no ESB.Produto.v2");
//            try
//            {
//                var modelosProposta = new List<ModeloProposta>();
//                Parallel.For(0, cnpjs.Length, i =>
//                {
//                    var cnpjCanal = cnpjs[i].Split('|');
//                    short? canalVenda;
//                    if (cnpjCanal.Length > 1)
//                    {
//                        canalVenda = short.Parse(cnpjCanal[1]);
//                    }
//                    else
//                    {
//                        canalVenda = null;
//                    }

//                    var resultadoPesquisarModelos = ServiceWcf<INegociacaoService>.UseSync(neg => neg.PesquisarModelosDeProposta(new PesquisaModelosDeProposta
//                    {
//                        Cnpj = long.Parse(cnpjCanal[0]),
//                        CanalDeVenda = canalVenda.GetValueOrDefault(0)
//                    }));

//                    if (resultadoPesquisarModelos.HouveErrosDuranteProcessamento)
//                    {    
//                        //throw new ApplicationException(string.Join(", ", resultadoPesquisarModelos.Mensagens));
//                    }
//                    else
//                        modelosProposta.AddRange(resultadoPesquisarModelos.Valor);
//                });

//                sw.Stop();
//                log.Info($"Terminou de buscar os modelos de proposta no ESB.Produto.v2 em {sw.ElapsedMilliseconds}");

//                log.Info("Limpando coleção de modelos de proposta.");
//                await documents.DeleteDocumentCollectionAsync(UriFactory.CreateDocumentCollectionUri("Venda", "DePara"));
//                log.Info("Terminou de limpar os modelos de proposta.");

//                log.Info("Salvando De/Para Sysprev Esim.");
//                var tasks   = new List<Task>();
//                foreach (var produto in modelosProposta.SelectMany(mp => mp.Produtos).Distinct(new ProdutoComparer()))
//                {
//                    foreach (var cobertura in produto.Coberturas)
//                    {
//                        tasks.Add(deparas.AddAsync(new
//                        {
//                            IdProduto = produto.Id,
//                            IdItemProduto = cobertura.ItemProdutoId,
//                            CdPlano = produto.CodigoPlanoSysPrev,
//                            CdBenef = cobertura.CodigoBeneficioSysPrev
//                        }));

//                    }                    
//                }


                

//                Task.WaitAll(tasks.ToArray());
//                log.Info("Terminou de salvar  De/Para Sysprev Esim.");
//            }
//            catch (AggregateException agex)
//            {
//                var msg = string.Empty;
//                agex.InnerExceptions.ToList().ForEach(e => msg += $"{e.GetType().Name} \n " + e.Message);
//                return req.CreateErrorResponse(HttpStatusCode.InternalServerError, msg);
//            }
//            catch (Exception ex)
//            {
//                return req.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
//            }

//            return req.CreateResponse(HttpStatusCode.OK);
//        }
//        private class ProdutoComparer : EqualityComparer<ProdutoNegociado>
//        {
//            public override bool Equals(ProdutoNegociado x, ProdutoNegociado y)
//            {
//                return x.Id == y.Id && x.Coberturas.All(c => y.Coberturas.Exists(c2 => c2.ItemProdutoId == c.ItemProdutoId));
//            }

//            public override int GetHashCode(ProdutoNegociado obj)
//            {
//                return obj.Id.GetHashCode();
//            }
//        }
//    }
//}
