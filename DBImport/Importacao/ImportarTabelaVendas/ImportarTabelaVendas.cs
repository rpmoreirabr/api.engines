//using System;
//using System.Collections.Generic;
//using System.Data.SqlClient;
//using System.Diagnostics;
//using System.Linq;
//using System.Net;
//using System.Net.Http;
//using System.Threading.Tasks;
//using Api.Engines.Venda.Infra;
//using Api.Engines.Venda.Model;
//using Microsoft.Azure.Documents.Client;
//using Microsoft.Azure.WebJobs;
//using Microsoft.Azure.WebJobs.Extensions.Http;
//using Microsoft.Azure.WebJobs.Host;
//using Contrato = Mongeral.ESB.Produto.Contrato.v2.Dados;
//using Mongeral.ESB.Produto.Contrato.v2.Operacoes;

//namespace Api.Engines.Venda.Importacao.ImportarTabelaVendas
//{
//    public static class ImportarTabelaVendas
//    {
//        [FunctionName("ImportarTabelaVendas")]
//        public static async Task<HttpResponseMessage> Run([HttpTrigger(AuthorizationLevel.Function, "get", "post", Route = null)]HttpRequestMessage req,
//            [DocumentDB("Venda", "TabelaVenda", Id = "id", CreateIfNotExists = true)] IAsyncCollector<dynamic> tabelaVenda,
//            [DocumentDB("Venda", "TabelaVenda", Id = "id")] DocumentClient documents,
//            TraceWriter log)
//        {
//            try {
//                var sw = new Stopwatch();
//                var modelosProposta = new List<Contrato.ModeloProposta>();
//                var cnpjs = Environment.GetEnvironmentVariable("Clientes.Cnpj").Split(',');
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

//                    var resultadoPesquisarModelos = ServiceWcf<INegociacaoService>.UseSync(neg => neg.PesquisarModelosDeProposta(new Contrato.PesquisaModelosDeProposta
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

//                sw.Start();
//                log.Info("Buscando tabela de vendas");

//                var coberturas = new List<DadosCobertura>();
//                using (var sqlConnection = new SqlConnection(Environment.GetEnvironmentVariable("csTabelaVenda")))
//                {
//                    sqlConnection.Open();
//                    var sqlCmd = sqlConnection.CreateCommand();
//                    var modelos = string.Empty;
//                    modelosProposta.ForEach(mp => modelos += $"'{mp.Codigo}',");
//                    modelos = modelos.Substring(0, modelos.Length - 1);

//                    sqlCmd.CommandText = $@"SELECT
//                            D.CodigoPlano,
//                            D.ValorBeneficio,
//                            D.ValorContribuicao,
//                            D.CodigoCobertura,
//                            C.ValorChave,
//                            C.Sexo,
//                            C.Conjuge,
//                            C.IdadeInicio,
//                            C.IdadeFim,
//                            D.IdComposicao,
//                            M.Sigla as CodigoModeloProposta
//                        FROM
//                            II_Composicao C
//                        INNER JOIN II_ModelosPropostas M ON M.Id = C.IdModelo
//                        INNER JOIN II_DadosComposicao D ON D.IdComposicao = C.Id
//                        WHERE M.Sigla IN ({modelos})
//                        ORDER BY
//                            D.CodigoPlano,
//                            D.CodigoCobertura";
//                    sqlCmd.CommandType = System.Data.CommandType.Text;
//                    using (var reader = await sqlCmd.ExecuteReaderAsync())
//                    {
//                        while (reader.Read())
//                            coberturas.Add(new DadosCobertura
//                            {
//                                CodigoPlano = Convert.ToInt32(reader["CodigoPlano"]),
//                                CodigoCobertura = Convert.ToInt32(reader["CodigoCobertura"]),
//                                ValorBeneficio = Convert.ToDecimal(reader["ValorBeneficio"]),
//                                ValorContribuicao = Convert.ToDecimal(reader["ValorContribuicao"]),
//                                ValorChave = Convert.ToDecimal(reader["ValorChave"]),
//                                Sexo = Convert.ToInt16(reader["Sexo"]),
//                                Conjuge = Convert.ToBoolean(reader["Conjuge"]),
//                                IdadeFim = Convert.ToInt32(reader["IdadeFim"]),
//                                IdadeInicio = Convert.ToInt32(reader["IdadeInicio"]),
//                                CodigoComposicao = Convert.ToInt32(reader["IdComposicao"])
//                            });
//                    }
//                }

//                sw.Stop();
//                log.Info($"Terminou de buscar as tabelas de vendas em {sw.ElapsedMilliseconds}");

//                log.Info("Limpando coleção de tabela de vendas.");
//               //await documents.DeleteDocumentCollectionAsync(UriFactory.CreateDocumentCollectionUri("Venda", "TabelaVenda"));
//                log.Info("Terminou de limpar as tabelas de vendas.");

//                log.Info("Salvando De/Para Sysprev Esim.");
//                var tasks = new List<Task>();
//                foreach (var cobertura in coberturas)
//                {
//                    tasks.Add(tabelaVenda.AddAsync(cobertura));
//                }
//                Task.WaitAll(tasks.ToArray());
//                log.Info("Terminou de salvar tabela de vendas.");
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

//    }
//}

