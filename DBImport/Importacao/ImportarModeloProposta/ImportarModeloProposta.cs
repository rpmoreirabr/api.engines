using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Api.Engines.Venda.Infra;
using Microsoft.Azure.Documents.Client;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Azure.WebJobs.Host;
using Mongeral.ESB.Produto.Contrato.v2.Operacoes;
using Mongeral.ESB.Produto.Contrato.v2.Dados;
using Newtonsoft.Json;
using System.Text;

namespace Api.Engines.Venda.Importacao.ImportarModeloProposta
{
    public static class ImportarModeloProposta
    {
        [FunctionName("ImportarModeloProposta")]
        public static async Task<HttpResponseMessage> Run([HttpTrigger(AuthorizationLevel.Function, "get", "post", Route = null)]HttpRequestMessage req,
            [DocumentDB("Venda", "ModelosNegocio", Id = "id", CreateIfNotExists = true, CollectionThroughput = 4000)] IAsyncCollector<dynamic> modelosNegocio,
            [DocumentDB("Venda", "ModelosNegocio", Id = "id")] DocumentClient collectionModelosNegocio,
            TraceWriter log)
        {
            var cnpjs = Environment.GetEnvironmentVariable("Clientes.Cnpj").Split(',');
            var modelosNegocioRetornados = new ConcurrentDictionary<Tuple<string, string>, List<Model.ModeloProposta>>();
            var modelosPropostaRetornados = new ConcurrentBag<ModeloProposta>();
            Stopwatch sw = new Stopwatch();
            sw.Start();
            log.Info("Buscando modelos de proposta no ESB.Produto.v2");
            try
            {
                Parallel.For(0, cnpjs.Length, i =>
                {
                    var cnpjCanal = cnpjs[i].Split('|');
                    var servicoModeloProposta = new ServicoModeloProposta();
                    short? canalVenda;
                    if (cnpjCanal.Length > 1)
                    {
                        canalVenda = short.Parse(cnpjCanal[1]);
                    }
                    else
                    {
                        canalVenda = null;
                    }

                    var pesquisa = new PesquisaModelosDeProposta
                    {
                        Cnpj = Int64.Parse(cnpjCanal[0]),
                        CanalDeVenda = canalVenda.GetValueOrDefault(0)
                    };


                    var resultadoPesquisarModelos = ServiceWcf<INegociacaoService>.UseSync(neg => neg.PesquisarModelosDeProposta(pesquisa));
                    if (resultadoPesquisarModelos.HouveErrosDuranteProcessamento)
                        throw new ApplicationException(string.Join(", ", resultadoPesquisarModelos.Mensagens));

                    resultadoPesquisarModelos.Valor.ForEach(rpm => modelosPropostaRetornados.Add(rpm));

                    var resultado = servicoModeloProposta.ObterTodos(resultadoPesquisarModelos.Valor);
                    modelosNegocioRetornados.TryAdd(new Tuple<string, string>(cnpjCanal[0], canalVenda?.ToString()), resultado.ToList());

                });

                sw.Stop();
                log.Info($"Terminou de buscar os modelos de proposta no ESB.Produto.v2 em {sw.ElapsedMilliseconds}");

                log.Info("Limpando coleção de modelos de negócio.");
                var deleteMnCollection = collectionModelosNegocio.DeleteDocumentCollectionAsync(UriFactory.CreateDocumentCollectionUri("Venda", "ModelosNegocio"));
           
                await deleteMnCollection;
                log.Info("Terminou de limpar os modelos de negócio.");

                log.Info("Salvando modelos de negócio.");
                var tasksInsertMn = new List<Task>();
                foreach (var modeloNegocio in modelosNegocioRetornados)
                {
                    Task.Run(async () => {
                        var data = new
                        {
                            Cnpj = modeloNegocio.Key.Item1.Trim(),
                            CanalVenda = modeloNegocio.Key.Item2,
                            Modelos = modeloNegocio.Value
                        };

                        var size = Encoding.UTF8.GetBytes(await Task.Factory.StartNew(() => JsonConvert.SerializeObject(data)));
                        if (size.Length > 2000000)
                        {
                            decimal i = 0m;
                            do
                            {
                                tasksInsertMn.Add(modelosNegocio.AddAsync(new
                                {
                                    data.Cnpj,
                                    data.CanalVenda,
                                    Modelos = data.Modelos.GetRange((int)i * 8, (int)i*8+8 > data.Modelos.Count ? data.Modelos.Count - (int)i*8 : 8)
                                }));
                                i++;
                            } while (i < ((decimal) data.Modelos.Count / 8));
                        }
                        else {
                            tasksInsertMn.Add(modelosNegocio.AddAsync(data));
                        };
                    }).Wait();
                }

                Task.WaitAll(tasksInsertMn.ToArray());
                log.Info("Terminou de salvar modelos de negócio.");

            }
            catch (AggregateException agex)
            {
                var msg = string.Empty;
                agex.InnerExceptions.ToList().ForEach(e => msg += $"{e.GetType().Name} \n " + e.Message);
                return req.CreateErrorResponse(HttpStatusCode.InternalServerError, msg);
            }
            catch(Exception ex)
            {
                return req.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }

            return req.CreateResponse(HttpStatusCode.OK);
        }
    }
}
