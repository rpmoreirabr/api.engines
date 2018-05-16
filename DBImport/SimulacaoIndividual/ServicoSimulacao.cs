using Api.Engines.Venda.Exceptions;
using Api.Engines.Venda.Extensions;
using Api.Engines.Venda.Infra;
using Api.Engines.Venda.Model;
using Api.Engines.Venda.Model.Enum;
using Mongeral.ESB.Pessoa.Contrato.Integracao.Dados;
using Mongeral.ESB.Pessoa.Contrato.Integracao.Operacoes;
using Mongeral.ESB.Produto.Contrato.v2.Operacoes;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Threading.Tasks;
using Contratos = Mongeral.ESB.Produto.Contrato.v2.Dados;
using ContratosEnum = Mongeral.ESB.Produto.Contrato.v2.Enumerations;

namespace Api.Engines.Venda.SimulacaoIndividual
{
    public class ServicoSimulacao
    {
        private List<Observacao> Mensagens => new List<Observacao>();

        public RegrasContratacao ObterRegrasContratacao(ModeloPropostaCompleto modeloProposta,
            long cpfTitular,
            DateTime dataNascimentoTitular,
            Model.Enum.SexoEnum sexoTitular,
            string ufTitular,
            Contratos.Profissao profissaoTitular,
            short periodicidade,
            Model.Enum.SexoEnum sexoConjuge,
            DateTime dataNascimentoConjuge,
            short prazoCerto,
            short tempoPrazoAntecipado,
            short idadePagamentoAntecipado,
            short prazoDecrescimo,
            Model.Enum.TipoRelacaoSegurado tipoRelacaoSegurado,
            decimal renda)
        {
            var produtosParaSimulacao = this.ObterProdutosSemRestricoes(modeloProposta.Produtos, tipoRelacaoSegurado, profissaoTitular, dataNascimentoTitular, ufTitular);
            var limitesOperacionais = this.ObterLimitesDisponiveis(modeloProposta.PoliticaAceitacao, cpfTitular, dataNascimentoTitular, ufTitular, profissaoTitular, renda, modeloProposta.Produtos);
            //var retorno = MontarRegrasContratacao(limitesOperacionais, modeloProposta.Produtos);
            var calculo = CalcularPremioCapitalSemCustoFixo(dataNascimentoTitular, sexoTitular, ufTitular, profissaoTitular.CBO, periodicidade, sexoConjuge, dataNascimentoConjuge, prazoCerto, tempoPrazoAntecipado, idadePagamentoAntecipado, prazoDecrescimo, modeloProposta);
            var retorno = MontarRegrasContratacao(limitesOperacionais, calculo);

            retorno.TicketMinimo = (decimal) modeloProposta.TicketMinimo.GetValueOrDefault();

            return retorno;
        }

        public RegrasContratacao MontarRegrasContratacao(List<LimiteDisponivel> limitesDisponiveis, List<ContratacaoProduto> produtos, short prazoCerto = 0)
        {
            var retorno = new RegrasContratacao();
            retorno.Observacoes = Mensagens;

            var limites = from l in limitesDisponiveis
                          from p in l.Produtos
                          select new { Coberturas = p.CoberturasLimite, l.Causa, l.ValorMaximo };

            foreach (var cobertura in produtos.SelectMany(p => p.CoberturasLimite))
            {
                var lim = limites.Where(l => l.Coberturas.Select(cob => cob.IdItemProduto).Contains(cobertura.IdItemProduto)).FirstOrDefault();
                cobertura.Limite = lim.ValorMaximo;
                cobertura.Causa = lim.Causa;
            }
            retorno.Produtos = produtos;

            return retorno;
        }


        private List<LimiteDisponivel> ObterLimitesDisponiveis(PoliticaAceitacao politicaAceitacao,
            long cpf,
            DateTime dataNascimento,
            string uf,
            Contratos.Profissao profissao,
            decimal renda,
            List<Produto> produtos)
        {
            if (politicaAceitacao == null)
            {
                throw new ArgumentNullException(nameof(politicaAceitacao));
            }

            var limites = new ConcurrentBag<LimiteDisponivel>();
            var capitaisAcumuladosCliente = ObterCapitalSegurado(new PesquisaCapitalSegurado()
            {
                Cpf = cpf,
                DataNascimento = dataNascimento
            });

            var taskFaixaEtaria = Task.Run(() =>
            {
                politicaAceitacao.LimitesOperacionaisPorFaixaEtaria
                    .Where(l => l.IdadeInicial <= dataNascimento.Idade() && l.IdadeFinal >= dataNascimento.Idade())
                    .ToList()
                    .ForEach(l =>
                    {
                        limites.Add(CalcularLimiteDisponivel(l, capitaisAcumuladosCliente, Convert.ToDecimal(l.ValorMaximoCapitalSegurado), "Faixa Etária", produtos));
                    });
            });
            var taskProfissao = Task.Run(() =>
            {
                politicaAceitacao.LimitesOperacionaisPorProfissao
                    .Where(l => l.ProfissoesId.Contains(profissao.Id))
                    .ToList()
                    .ForEach(l =>
                    {
                        limites.Add(CalcularLimiteDisponivel(l, capitaisAcumuladosCliente, Convert.ToDecimal(l.ValorMaximoCapitalSegurado), "Profissão", produtos));
                    });
            });
            var taskRenda = Task.Run(() =>
            {
                politicaAceitacao.LimitesOperacionaisPorRenda
                    .Where(l => l.IdadeInicial <= dataNascimento.Idade() && l.IdadeFinal >= dataNascimento.Idade())
                    .ToList()
                    .ForEach(l =>
                    {
                        var valorMaximo = ObterCapitalAcumuladoPorCobertura(l, capitaisAcumuladosCliente);
                        limites.Add(CalcularLimiteDisponivel(l, capitaisAcumuladosCliente, Convert.ToDecimal(renda * l.MultiploRenda), "Renda", produtos));
                    });
            });

            taskFaixaEtaria.Wait();
            taskProfissao.Wait();
            taskRenda.Wait();

            var menoresLimites = from lim in (from l in limites group l by l.Causa)
                                 select new LimiteDisponivel()
                                 {
                                     Causa = lim.First().Causa,
                                     Produtos = lim.First().Produtos,
                                     ValorMaximo = lim.Min(l => l.ValorMaximo)
                                 };

            return menoresLimites.ToList();
        }

        private List<CapitalSegurado> ObterCapitalSegurado(PesquisaCapitalSegurado parametros)
        {
            var resultado = ServiceWcf<IAcumuloDeCapitalService>.UseSync(s => s.ObterCapitalSegurado(parametros));
            if (resultado.HouveErrosDuranteProcessamento)
            {
                var obs = new Observacao
                {
                    ID = 21,
                    Descricao = "Não foi possível validar os Capitais Acumulados",
                    Itens = resultado.Mensagens
                };
            }
            else
            {
                if (resultado.Mensagens != null && resultado.Mensagens.Count > 0)
                    resultado.Mensagens.ForEach(x => Mensagens.Add(new Observacao(descricao: x)));
            }

            return resultado.Valor;
        }

        private List<Produto> ObterProdutosSemRestricoes(List<Produto> produtos, Model.Enum.TipoRelacaoSegurado? tipoRelacaoSegurado, Contratos.Profissao profissaoProponente, DateTime dataNascimento, string uf)
        {
            var produtosParaSimulacao = new List<Produto>();

            foreach (var produto in produtos)
            {
                string motivoRestricaoProduto;

                bool produtoRestrito = ProdutoRestrito(produto, tipoRelacaoSegurado, profissaoProponente, out motivoRestricaoProduto);

                if (produtoRestrito)
                {
                    Mensagens.Add(new Observacao(descricao: motivoRestricaoProduto));

                    continue;
                }

                var produtoParaSimulacao = ObjectClone.DoClone(produto);

                var coberturasObrigatoriasRemovidas = new List<Model.Cobertura>();

                foreach (var cobertura in produto.Coberturas)
                {
                    string motivoRestricaoCobertura;

                    bool coberturaRestrita = CoberturaRestrita(cobertura, dataNascimento, uf, profissaoProponente, out motivoRestricaoCobertura);

                    if (coberturaRestrita && cobertura.Obrigatoria.Value)
                    {
                        coberturasObrigatoriasRemovidas.Add(cobertura);

                        Mensagens.Add(new Observacao(descricao: motivoRestricaoCobertura));

                        continue;
                    }

                    if (coberturaRestrita)
                    {
                        Mensagens.Add(new Observacao(descricao: motivoRestricaoCobertura));

                        continue;
                    }

                    produtoParaSimulacao.Coberturas.Add(ObjectClone.DoClone(cobertura));
                }

                if (coberturasObrigatoriasRemovidas.Any())
                {
                    string mensagem = $"Produto {produto.Id} - {produto.Descricao} removido da simulação pois possui restrição em alguma(s) cobertura(s) obrigatória(s). Cobertura(s): { string.Join(", ", coberturasObrigatoriasRemovidas.Select(c => $"{c.Id} - {c.Descricao}")) }";

                    Mensagens.Add(new Observacao(descricao: mensagem));

                    continue;
                }

                produtosParaSimulacao.Add(produtoParaSimulacao);
            }

            return produtosParaSimulacao;
        }

        private decimal ObterCapitalAcumuladoPorCobertura(Limite l, List<CapitalSegurado> capitaisAcumuladosCliente)
        {
            if (capitaisAcumuladosCliente == null || !capitaisAcumuladosCliente.Any() || l.Coberturas == null || !l.Coberturas.Any())
                return 0M;

            return capitaisAcumuladosCliente
                .Where(cac => l.Coberturas.Contains(cac.CoberturaId))
                .Sum(cac => cac.ValorCapitalSegurado);
        }

        private const int TIPOPROPONENTECONJUGE = 2;

        private bool ProdutoRestrito(Produto produto, Model.Enum.TipoRelacaoSegurado? tipoRelacaoSegurado, Contratos.Profissao profissaoProponente, out string motivo)
        {
            motivo = string.Empty;

            //produto.ProfissoesAceitas

            if (produto.ProfissoesAceitas.Any() && !produto.ProfissoesAceitas.Contains(profissaoProponente.Id))
            {
                motivo = $"Produto {produto.Id} - {produto.Descricao} removido da simulação pois profissão do proponente ({profissaoProponente.CBO} - {profissaoProponente.Descricao}) não é aceita para contratação";

                return true;
            }

            if ((tipoRelacaoSegurado.HasValue && produto.TipoProponente.Id != (int)tipoRelacaoSegurado) || (!tipoRelacaoSegurado.HasValue && produto.TipoProponente.Id == TIPOPROPONENTECONJUGE))
            {
                motivo = $"Produto {produto.Id} - {produto.Descricao} removido da simulação pois é um produto de cônjugue e o proponente da simulação é titular";

                return true;
            }

            return false;
        }

        private bool CoberturaRestrita(Model.Cobertura cobertura, DateTime dataNascimento, string uf, Contratos.Profissao profissaoProponente, out string motivo)
        {
            motivo = string.Empty;

            if (dataNascimento.Idade() < cobertura.IdadeMinima)
            {
                motivo = $"Cobertura {cobertura.Id} - {cobertura.Descricao} removida da simulação pois a idade do proponente ({dataNascimento.Idade()}) é inferior a idade mínima para contratação {cobertura.IdadeMinima}";

                return true;
            }

            if (dataNascimento.Idade() > cobertura.IdadeMaxima)
            {
                motivo = $"Cobertura {cobertura.Id} - {cobertura.Descricao} removida da simulação pois a idade do proponente ({dataNascimento.Idade()}) é superior a idade máxima para contratação {cobertura.IdadeMaxima}";

                return true;
            }

            if (cobertura.ProfissoesRecusadas.Contains(profissaoProponente.Id))
            {
                motivo = $"Cobertura {cobertura.Id} - {cobertura.Descricao} removida da simulação pois a profissão do proponente ({profissaoProponente.CBO} - {profissaoProponente.Descricao}) é recusada pela cobertura";

                return true;
            }

            if (cobertura.UFsRecusadas.Contains(uf))
            {
                motivo = $"Cobertura {cobertura.Id} - {cobertura.Descricao} removida da simulação pois a UF do proponente ({uf}) é recusada pela cobertura";

                return true;
            }

            return false;
        }

        private LimiteDisponivel CalcularLimiteDisponivel(Limite l, List<CapitalSegurado> capitaisAcumuladosCliente, decimal valorMaximoCapitalSegurado, string tipoLimite, List<Produto> produtos, short prazoCerto = 0)
        {
            var capitalAcumulado = ObterCapitalAcumuladoPorCobertura(l, capitaisAcumuladosCliente);
            var valorMaximo = valorMaximoCapitalSegurado - capitalAcumulado;
            var retorno = new LimiteDisponivel()
            {
                Causa = l.Causa,
                ValorMaximo = valorMaximo <= decimal.Zero ? decimal.Zero : valorMaximo,
                Produtos = produtos.Where(p =>
                {
                    return p.Coberturas.Any(c => l.Coberturas.Contains(c.IdCoberturaEsim.GetValueOrDefault()));
                }).Select(p => new ContratacaoProduto()
                {
                    IdProduto = p.IdEsim.Value,
                    Descricao = p.Descricao,
                    Obrigatorio = p.Obrigatorio,
                    CoberturasLimite = p.Coberturas.Select(c => new ContratacaoCobertura()
                    {
                        Descricao = c.Descricao,
                        IdItemProduto = c.IdEsim.Value,
                        Obrigatorio = c.Obrigatoria.Value,
                        Tipo = c.Tipo,
                        TipoRelacaoSegurado = c.TipoRelacaoSegurado,
                        TipoCapitalBase = c.TaxaFixa ? TipoCapitalBase.CapitalFixo : TipoCapitalBase.CapitalVariavel,
                        CapitalBase = c.TaxaFixa ? (decimal)c.CapitalFixo.GetValueOrDefault() : 1000M,
                        PrazoCerto = c.PrazoCerto.Contains(prazoCerto) ? prazoCerto : 0
                    }).ToList()
                }).ToList()
            };

            //excedeu o limite
            if (valorMaximo >= valorMaximoCapitalSegurado)
                Mensagens.Add(new Observacao(descricao: $"O proponente excedeu o limite de contração por {tipoLimite} que está configurado com o valor R$ {valorMaximoCapitalSegurado} para a causa '{l.Causa}'"));

            //limite reduzido
            if (valorMaximo > decimal.Zero && valorMaximo < valorMaximoCapitalSegurado)
                Mensagens.Add(new Observacao(descricao: $"O limite por {tipoLimite} do proponente para a causa '{l.Causa}' foi reduzido de R$ {valorMaximoCapitalSegurado} para R$ {valorMaximo} por ele já ter outras coberturas de mesmo tipo contratadas"));

            //tem limite total
            if (valorMaximo == decimal.Zero && valorMaximoCapitalSegurado > decimal.Zero)
                Mensagens.Add(new Observacao(descricao: $"O proponente possui limite total de R$ {valorMaximoCapitalSegurado} para o tipo de cobertura '{l.Causa}' disponível para contratação"));

            return retorno;
        }

        public List<ContratacaoProduto> CalcularPremioCapitalSemCustoFixo(DateTime dataNascimentoTitular,
            Model.Enum.SexoEnum sexoTitular,
            string ufTitular,
            string cboTitular,
            short periodicidade,
            Model.Enum.SexoEnum sexoConjuge,
            DateTime dataNascimentoConjuge,
            short prazoCerto,
            short tempoPrazoAntecipado,
            short idadePagamentoAntecipado,
            short prazoDecrescimo,
            ModeloPropostaCompleto modeloProposta)
        {
            return CalcularPremioCapital(dataNascimentoTitular, 
                sexoTitular, 
                ufTitular, 
                cboTitular, 
                periodicidade, 
                sexoConjuge, 
                dataNascimentoConjuge,
                prazoCerto,
                tempoPrazoAntecipado,
                idadePagamentoAntecipado,
                prazoDecrescimo,
                modeloProposta, 
                EnumTipoCalculoPremioCapital.CalculoSemCustoFixo);
        }

        public List<ContratacaoProduto> CalcularPremioCapitalComCustoFixo(DateTime dataNascimentoTitular,
            Model.Enum.SexoEnum sexoTitular,
            string ufTitular,
            string cboTitular,            
            Model.Enum.SexoEnum sexoConjuge,
            DateTime dataNascimentoConjuge,
            short periodicidade,
            short prazoCerto,
            short tempoPrazoAntecipado,
            short idadePagamentoAntecipado,
            short prazoDecrescimo,
            ModeloPropostaCompleto modeloProposta)
        {
            return CalcularPremioCapital(dataNascimentoTitular, 
                sexoTitular, 
                ufTitular, 
                cboTitular, 
                periodicidade, 
                sexoConjuge, 
                dataNascimentoConjuge, 
                prazoCerto,
                tempoPrazoAntecipado,
                idadePagamentoAntecipado,
                prazoDecrescimo, 
                modeloProposta, 
                EnumTipoCalculoPremioCapital.CalculoComCustoFixo);
        }

        //3a fase 
        private List<ContratacaoProduto> CalcularPremioCapital(DateTime dataNascimentoTitular,
            Model.Enum.SexoEnum sexoTitular,
            string ufTitular,
            string cboTitular,
            short periodicidade,
            Model.Enum.SexoEnum sexoConjuge,
            DateTime dataNascimentoConjuge,
            short prazoCerto,
            short tempoPrazoAntecipado,
            short idadePagamentoAntecipado,
            short prazoDecrescimo,
            ModeloPropostaCompleto modeloProposta, 
            EnumTipoCalculoPremioCapital tipoCalculoPremio)
        {
            var coberturasCalculadas = new List<ContratacaoCobertura>();
            var parametrosCalculo = new List<Contratos.ParametrosCalculo>();
            var valoresRepasse = new Dictionary<int, decimal>();
            var coberturasNaoExibidas = new List<Model.Cobertura>();

            foreach (var produto in modeloProposta.Produtos)
                parametrosCalculo.AddRange(GerarParametrosParaCalculo(dataNascimentoTitular,
                    sexoTitular, 
                    ufTitular, 
                    cboTitular, 
                    periodicidade, 
                    sexoConjuge, 
                    dataNascimentoConjuge,
                    prazoCerto,
                    tempoPrazoAntecipado,
                    idadePagamentoAntecipado,
                    prazoDecrescimo,
                    modeloProposta, 
                    produto, 
                    valoresRepasse, 
                    coberturasNaoExibidas));

            try
            {
                AbaterValorServicos(valoresRepasse, parametrosCalculo);
                var resultado = ServiceWcf<ICalculoService>.UseSync(s => s.CalcularValorContribuicaoBeneficio(parametrosCalculo));

                if (resultado.HouveErrosDuranteProcessamento)
                    throw new CalculoException(string.Join(Environment.NewLine, resultado.Mensagens));

                coberturasCalculadas.AddRange(resultado.Valor.Select(calculo => new ContratacaoCobertura
                {
                    CapitalSegurado = calculo.ValorBeneficio,
                    ModelosProposta = new List<string> { modeloProposta.Nome },
                    Premio = tipoCalculoPremio == EnumTipoCalculoPremioCapital.CalculoSemCustoFixo ? ObterPremioSemCustoFixo(calculo.ValorPremioComercial, calculo.CustoFixoCarregamento) : calculo.ValorPremioComercial,
                    IdItemProduto = Convert.ToInt32(calculo.IdentificadorExterno),
                    CustoFixo = calculo.CustoFixoCarregamento
                }));

                AdicionarValorServicos(valoresRepasse, coberturasCalculadas);
            }
            catch (TimeoutException)
            {
                AdicionarObservacaoTimeout(parametrosCalculo);
            }
            catch (CommunicationException)
            {
                AdicionarObservacaoTimeout(parametrosCalculo);
            }

            return RetornarProdutosPreenchidos(modeloProposta.Produtos, 
                coberturasCalculadas, 
                coberturasNaoExibidas, prazoCerto,
                tempoPrazoAntecipado,
                idadePagamentoAntecipado,
                prazoDecrescimo);
        }

        private static List<ContratacaoProduto> RetornarProdutosPreenchidos(List<Produto> produtos, 
            List<ContratacaoCobertura> coberturasCalculadas, 
            List<Model.Cobertura> coberturasNaoExibidas,
            short prazoCerto,
            short tempoPrazoAntecipado,
            short idadePagamentoAntecipado,
            short prazoDecrescimo)
        {
            var produtosCalculados = new List<ContratacaoProduto>();

            foreach (var produto in produtos)
            {
                var produtoCalculado = new ContratacaoProduto
                {
                    Descricao = produto.Descricao,
                    IdProduto = produto.Id.GetValueOrDefault(),
                    Obrigatorio = produto.Obrigatorio,
                    CoberturasLimite = new List<ContratacaoCobertura>()
                };

                foreach (var cobertura in produto.Coberturas)
                {
                    var coberturaProposta = coberturasCalculadas.FirstOrDefault(calc => calc.IdItemProduto == cobertura.IdEsim);

                    if (coberturaProposta == null || coberturasNaoExibidas.Any(x => x.IdEsim == coberturaProposta.IdItemProduto))
                        continue;

                    produtoCalculado.CoberturasLimite.Add(new ContratacaoCobertura
                    {
                        CapitalSegurado = coberturaProposta.CapitalSegurado,
                        Descricao = cobertura.Descricao,
                        PrazoCerto = prazoCerto,
                        IdItemProduto = coberturaProposta.IdItemProduto,
                        Premio = coberturaProposta.Premio,
                        IdadePagamentoAntecipado = idadePagamentoAntecipado,
                        TempoPrazoAntecipado = tempoPrazoAntecipado,
                        PrazoDecrescimo = prazoDecrescimo,
                        Tipo = cobertura.Tipo,
                        CustoFixo = coberturaProposta.CustoFixo

                    });
                }

                produtosCalculados.Add(produtoCalculado);
            }

            return produtosCalculados;
        }

        private void AdicionarValorServicos(IDictionary<int, decimal> valoresRepasse, List<ContratacaoCobertura> valoresCalculados)
        {
            foreach (var cobertura in valoresCalculados.Where(c => c.Premio > 0 && valoresRepasse.ContainsKey(c.IdItemProduto)))
                cobertura.Premio += valoresRepasse[cobertura.IdItemProduto];
        }

        private void AbaterValorServicos(IDictionary<int, decimal> valoresRepasse, List<Contratos.ParametrosCalculo> parametrosCalculo)
        {
            foreach (var parametro in parametrosCalculo.Where(p => p.ValorPremio > 0 && valoresRepasse.ContainsKey(p.ItemProdutoId)))
                parametro.ValorPremio -= valoresRepasse[parametro.ItemProdutoId];
        }

        private void AdicionarObservacaoTimeout(List<Contratos.ParametrosCalculo> parametrosCalculo)
        {
            var obs = ObservacaoHelper.PreencherObservacao(6
                , itens: parametrosCalculo.Select(x => string.Concat("ItemProdutoId: ", x.ItemProdutoId)).ToArray()
                , origem: "CalculoCliente");

            Mensagens.Add(obs);
            throw new ServicoIndisponivelException(obs);
        }

        private List<Contratos.ParametrosCalculo> GerarParametrosParaCalculo(
            DateTime dataNascimentoTitular,
            Model.Enum.SexoEnum sexoTitular,
            string ufTitular,
            string cboTitular,
            short periodicidade,
            Model.Enum.SexoEnum sexoConjuge,
            DateTime dataNascimentoConjuge,
            short PrazoCerto,
            short TempoPrazoAntecipado,
            short IdadePagamentoAntecipado,
            short PrazoDecrescimo,
            ModeloPropostaCompleto modeloProposta,
            Model.Produto produto,
            Dictionary<int, decimal> valoresRepasse,
            List<Model.Cobertura> coberturasNaoExibidas)
        {
            var retorno = new List<Contratos.ParametrosCalculo>();

            foreach (var cobertura in produto.Coberturas)
            {
                try
                {
                    CalcularRepasse(dataNascimentoTitular, cobertura, produto, modeloProposta, valoresRepasse, coberturasNaoExibidas);

                    var parametroDeCalculo = CriarParametroDeCalculo(sexoTitular, dataNascimentoTitular, ufTitular, cboTitular, periodicidade, PrazoCerto, TempoPrazoAntecipado, IdadePagamentoAntecipado, PrazoDecrescimo, modeloProposta, cobertura, produto);

                    AdicionarConjuge(sexoConjuge, dataNascimentoConjuge, parametroDeCalculo);
                    parametroDeCalculo.EhSimulacao = true;
                    retorno.Add(parametroDeCalculo);
                }
                catch (ProdutoException) { }
            }

            return retorno;
        }

        private void CalcularRepasse(
            DateTime dataNascimentoTitular,
            Cobertura cobertura,
            Produto produto,
            ModeloPropostaCompleto modeloProposta,
            Dictionary<int, decimal> valoresRepasse,
            List<Cobertura> coberturasNaoExibidas)
        {
            if (cobertura != null && cobertura.EhServico && cobertura.ValorServicoSomadoNaCoberturaDeReferencia)
            {
                decimal valorRepasse = 0;
                int idItemProduto = 0;
                if (cobertura.ValoresRepassadoAoCliente != null)
                {
                    valorRepasse = cobertura.ValoresRepassadoAoCliente.Where(
                            c => (c.TipoRepasseCliente == ContratosEnum.TipoRepasseClienteEnum.PorIdade &&
                                  dataNascimentoTitular.Idade() >= c.IdadeInicial &&
                                  dataNascimentoTitular.Idade() <= c.IdadeFinal) ||
                                 (c.TipoRepasseCliente == ContratosEnum.TipoRepasseClienteEnum.Fixo))
                        .Sum(x => x.Valor);
                }

                if (cobertura.ValorServicoSomadoNaCoberturaDeReferencia && produto.ReferenciaCoberturaId.HasValue)
                    idItemProduto = produto.Coberturas.Find(x => x.IdCoberturaEsim.GetValueOrDefault() == produto.ReferenciaCoberturaId.Value).IdEsim.GetValueOrDefault();
                else
                    idItemProduto = cobertura.IdEsim.GetValueOrDefault();

                if (idItemProduto != 0 && valorRepasse != 0)
                {
                    if (valoresRepasse.ContainsKey(idItemProduto))
                    {
                        valorRepasse += valoresRepasse[idItemProduto];
                        valoresRepasse.Remove(idItemProduto);
                    }

                    valoresRepasse.Add(idItemProduto, valorRepasse);
                }

                if (cobertura.EhServico && !cobertura.ExibeServicoNaListaDeCobertura)
                    coberturasNaoExibidas.Add(cobertura);
            }
        }

        private void AdicionarConjuge(Model.Enum.SexoEnum sexo, DateTime dataNascimento, Contratos.ParametrosCalculo parametroDeCalculo)
        {
            parametroDeCalculo.Conjuge = new Contratos.Conjuge
            {
                Sexo = (ContratosEnum.SexoEnum) Enum.Parse(typeof(ContratosEnum.SexoEnum), Enum.GetName(typeof(Model.Enum.SexoEnum), sexo)),
                DataNascimento = dataNascimento
            };
        }

        private static decimal ObterPremioSemCustoFixo(decimal premio, decimal custofixo)
        {
            return premio - custofixo;

        }      

        private Contratos.ParametrosCalculo CriarParametroDeCalculo(Model.Enum.SexoEnum sexoTitular, 
            DateTime dataNascimentoTitular, 
            string ufTitular, 
            string cboTitular,
            short periodicidade,
            short PrazoCerto,
            short TempoPrazoAntecipado,
            short IdadePagamentoAntecipado,
            short PrazoDecrescimo,
            ModeloPropostaCompleto modeloProposta, 
            Cobertura cobertura, 
            Produto produto)
        {
            ValidarCobertura(cobertura, produto);

            //TODO: Repassar valores de serviços marcados ao cliente
            return new Contratos.ParametrosCalculo
            {
                ValorBeneficio = cobertura.CapitalSegurado,
                ValorPremio = cobertura.Premio,
                DataCalculo = DateTime.Now,
                DataInicioVigencia = DateTime.Now,
                ItemProdutoId = cobertura.IdEsim.GetValueOrDefault(),
                PrazoCobertura = ObterPrazoCobertura(PrazoCerto, TempoPrazoAntecipado),
                Segurado = new Contratos.Segurado { Sexo = (ContratosEnum.SexoEnum) Enum.Parse(typeof(ContratosEnum.SexoEnum), Enum.GetName(typeof(Model.Enum.SexoEnum), sexoTitular)), DataNascimento = dataNascimentoTitular, UF = ufTitular, ProfissaoCBO = cboTitular },
                FormaContratacaoId = ObterFormaContratacaoDoModelo(cobertura.IdEsim.GetValueOrDefault(), modeloProposta),
                IdentificadorExterno = cobertura.IdEsim.ToString(),
                PeriodicidadeId = ObterPeriodicidade(periodicidade),
                TipoRenda = ObterTipoRenda(modeloProposta, cobertura),
                ClasseRiscoId = ObterClasseDeRiscoPadrao(modeloProposta, produto.IdEsim.GetValueOrDefault(), cobertura.IdEsim.GetValueOrDefault()),
                PrazoDecrecimo = PrazoDecrescimo,
                IdadePagamentoAntecipado = IdadePagamentoAntecipado,
                TempoPrazoAntecipado = TempoPrazoAntecipado
            };
        }

        private short ObterPrazoCobertura(short PrazoCerto, short TempoPrazoAntecipado)
        {
            return  PrazoCerto > 0 ? (short) PrazoCerto : TempoPrazoAntecipado > 0 ? (short) TempoPrazoAntecipado: (short) 0;
        }

        private static short ObterPeriodicidade(short periodicidade)
        {
            short[] periodicidadesValidas = new short[] { 2, 30, 90, 360, 180, 365 };

            return periodicidadesValidas.Contains(periodicidade) ? periodicidade : (short) 30;           
        }

        private short? ObterClasseDeRiscoPadrao(ModeloPropostaCompleto modeloProposta, int idProduto, int idItemProduto)
        {
            var produto = modeloProposta.Produtos.FirstOrDefault(p => p.Id == idProduto);
            if (produto == null) return null;

            var cobertura = produto.Coberturas.FirstOrDefault(c => c.IdEsim == idItemProduto);
            if (cobertura == null) return null;

            if (cobertura.ClasseDeRiscoPadraoParaContratacao == null) return null;

            return cobertura.ClasseDeRiscoPadraoParaContratacao.Id;
        }

        private short ObterFormaContratacaoDoModelo(int idItemProduto, ModeloPropostaCompleto modelo)
        {
            var produtos = modelo.Produtos.Where(p => p.Coberturas.Any(c => c.IdEsim == idItemProduto)).ToList();
            if (!produtos.Any())
                return 0;

            var coberturas = produtos.SelectMany(p => p.Coberturas.Where(c => c.IdEsim == idItemProduto)).ToList();

            if (!coberturas.Any())
                return 0;

            return coberturas.First().FormasContratacao.First(fc => fc.EhOpcaoPadrao).Id;
        }

        private static ContratosEnum.TipoRendaEnum ObterTipoRenda(ModeloPropostaCompleto modeloProposta, Cobertura cobertura)
        {
            var tipoRenda = ContratosEnum.TipoRendaEnum.NaoSeAplica;

            try
            {
                var formaContratacaoPadrao = cobertura.FormasContratacao.Single(x => x.EhOpcaoPadrao);

                var formaContratacao = (ContratosEnum.FormaContratacaoEnum)formaContratacaoPadrao.Id;

                if (formaContratacao == ContratosEnum.FormaContratacaoEnum.RendaMensal)
                {
                    var rendaPadrao = cobertura.Rendas.Single(x => x.EhPadrao);
                    tipoRenda = (ContratosEnum.TipoRendaEnum)rendaPadrao.Tipo.Id;
                }
            }
            catch (Exception)
            {
            }

            return tipoRenda;
        }

        private void ValidarCobertura(Cobertura cobertura, Produto produto)
        {
            if (cobertura.CapitalSegurado == 0 || cobertura.Premio == 0)
                return;

            var s = string.Format("IdItemProduto: {0} | Produto: {1}", cobertura.IdEsim, produto.IdEsim);

            var obs = ObservacaoHelper.PreencherObservacao(id: 5,
                origem: typeof(ContratacaoCobertura).ToString(),
                itens: new[] { s });

            Mensagens.Add(obs);
            throw new ProdutoException(obs);
        }
    }
}
