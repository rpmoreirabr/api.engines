using Mongeral.ESB.Produto.Contrato.v2.Operacoes;
using System;
using System.Collections.Generic;
using System.Linq;
using Contrato = Mongeral.ESB.Produto.Contrato.v2.Dados;
using Api.Engines.Venda.Infra;
using Api.Engines.Venda.Model;
using Api.Engines.Venda.Model.Enum;
using Api.Engines.Venda.Extensions;
using Mongeral.ESB.Produto.Contrato.v2.Enumerations;

namespace Api.Engines.Venda.Importacao.ImportarModeloProposta
{
    public class ServicoProduto 
    {       
        #region Métodos Públicos

        /// <summary>
        /// Obtém os produtos de um determinado modelo de proposta
        /// </summary>
        /// <param name="codigoModeloProposta"></param>
        /// <returns></returns>
        public IQueryable<Model.Produto> ObterTodos(string codigoModeloProposta)
        {
            var modeloProposta = BuscarInformacoesModelo(codigoModeloProposta);

            var politicaAceitacao = BuscarPoliticaAceitacao(codigoModeloProposta);

            var limites = politicaAceitacao.LimitesOperacionais;

            var produtos = new List<Model.Produto>();
            var produtosFiltrados = modeloProposta.Produtos.Where(p => !p.EstahRestrito).ToList();

            foreach (Contrato.ProdutoNegociado produto in produtosFiltrados)
            {
                Model.Produto produtoApi = ObterProduto(produto, limites, produtosFiltrados);
                produtos.Add(produtoApi);
            }

            return produtos.AsQueryable();
        }


        private Contrato.ModeloProposta BuscarInformacoesModelo(string codigoModeloProposta)
        {
            return ObterModeloPropostaDoServico(codigoModeloProposta);
        }

        private Contrato.ModeloProposta ObterModeloPropostaDoServico(string codigoModelo)
        {
            var modeloPropostaObtido = ServiceWcf<INegociacaoService>.UseSync(n => n.ObterModeloProposta(new Contrato.ModeloProposta { Codigo = codigoModelo }));

            if (modeloPropostaObtido.HouveErrosDuranteProcessamento)
                throw new Exception($"Erro ao obter o modelo de proposta com código '{codigoModelo}'");

            if (!modeloPropostaObtido.HouveErrosDuranteProcessamento && modeloPropostaObtido.Valor != null)
                return modeloPropostaObtido.Valor;

            return null;
        }



        private Contrato.PoliticaDeAceitacao BuscarPoliticaAceitacao(string codigoModeloProposta)
        {
           return ObterPoliticaAceitacaoDoServico(codigoModeloProposta);
        }

        private Contrato.PoliticaDeAceitacao ObterPoliticaAceitacaoDoServico(string codigoModelo)
        {
            var parametros = ObterParametroPoliticaDeAceitacao(codigoModelo);
            var resultadoPoliticaAceitacao = ServiceWcf<INegociacaoService>.UseSync(n => n.ObterLimitesOperacionais(new Contrato.ParametroLimitesOperacionais() { CodigoModeloProposta = codigoModelo, DataVigencia = DateTime.Now }));

            if (resultadoPoliticaAceitacao.HouveErrosDuranteProcessamento)
                throw new Exception($"Erro ao obter a política de aceitação do modelo de proposta com código '{codigoModelo}'");

            if (!resultadoPoliticaAceitacao.HouveErrosDuranteProcessamento && resultadoPoliticaAceitacao.Valor != null)
                return resultadoPoliticaAceitacao.Valor;

            return null;
        }





        /// <summary>
        /// Obtém um produto de um determinado modelo de proposta
        /// </summary>
        /// <param name="codigoModeloProposta">Código do modelo de proposta</param>
        /// <param name="id">Identificador do produto</param>
        /// <returns></returns>
        public Model.Produto ObterPorId(string codigoModeloProposta, int id)
        {
            var modeloProposta = BuscarInformacoesModelo(codigoModeloProposta);
            var politicaAceitacao = BuscarPoliticaAceitacao(codigoModeloProposta);

            var limites = politicaAceitacao.LimitesOperacionais;

            var produtosFiltrados = modeloProposta.Produtos.Where(p => !p.EstahRestrito).ToList();

            var produto = produtosFiltrados.FirstOrDefault(p => p.CodigoPlanoSysPrev == id);

            if (produto == null)
                throw new Exception($"Produto de Identificação '{id}' não foi encontrado no modelo de proposta '{codigoModeloProposta}'");

            var produtoApi = ObterProduto(produto, limites, produtosFiltrados);

            return produtoApi;
        }

        #endregion

        #region Métodos Privados

        /// <summary>
        /// ## REVER PUBLIC ##
        /// Constrói um objeto de produto para retorno com o resultado dos serviços de produtos e de limites
        /// </summary>
        /// <param name="produto">Produto negociado</param>
        /// <param name="limites">Limites operacionais</param>
        /// <returns>produto (Api)</returns>
        public Produto ObterProduto(Contrato.ProdutoNegociado produto, List<Contrato.LimiteOperacionalPorFaixa> limites, List<Contrato.ProdutoNegociado> produtos)
        {
            var produtoApi = new Model.Produto
            {
                Id = produto.CodigoPlanoSysPrev,
                IdEsim = produto.Id,
                Descricao = produto.NomeFantasia,
                DescricaoComercial = produto.DescricaoComercial ?? "",
                DataUltimaAlteracao = DateTime.Now,
                Obrigatorio = produto.ContratacaoObrigatoria,
                EstahRestrito = produto.EstahRestrito,
                ReferenciaCoberturaId = produto.ReferenciaCoberturaId,
                
                TipoProponente = new TipoProponente
                {
                    Id = produto.TipoProponente,
                    Descricao = ((TipoProponenteEnum)produto.TipoProponente).GetDescription()
                }
            };
            /*alterar*/
            produtoApi.Periodicidades = produto.RegraCobranca.Periodicidades.Select(p => new Periodicidade { Id = p, Descricao = ((PeriodicidadeEnum)p).GetDescription() }).ToList();

            produtoApi.Fundos = new List<Model.Fundo>();
            produtoApi.Coberturas = new List<Cobertura>();
            produtoApi.ProfissoesRecusadas = new List<int>();
            produtoApi.UFsRecusadas = new List<string>();
            produtoApi.IdadeAntecipacao = new List<int>();
            produtoApi.TempoAntecipacao = new List<int>();
            produtoApi.PrazoDecrescimo = new List<int>();
            produtoApi.PrazoCerto = new List<int>();
            produtoApi.PrazoRenda = new List<PrazoRenda>();
            
            foreach (Contrato.CoberturaProdutoNegociado cobertura in produto.Coberturas)
            {
                if (cobertura.CodigoBeneficioSysPrev == 0)
                    continue;

                var produtoCobertura = new Cobertura();
                produtoCobertura.Id = cobertura.CodigoBeneficioSysPrev;
                produtoCobertura.IdEsim = cobertura.ItemProdutoId;
                produtoCobertura.IdCoberturaEsim = cobertura.CoberturaId;
                produtoCobertura.Descricao = cobertura.NomeFantasia;
                produtoCobertura.DescricaoComercial = cobertura.DescricaoComercial ?? "";
                produtoCobertura.Obrigatoria = cobertura.ItemProdutoObrigatorio;
                produtoCobertura.IdadeMinima = cobertura.IdadeMinima;
                produtoCobertura.IdadeMaxima = cobertura.IdadeMaxima;
                produtoCobertura.IdadeExclusao = cobertura.IdadeExclusao;
                produtoCobertura.ExigeDPS = cobertura.ExigeDps;
                produtoCobertura.CoberturaPrincipal = cobertura.CoberturaId == produto.ReferenciaCoberturaId;
                produtoCobertura.ValorFixo = ObterValorFixo(cobertura);
                produtoCobertura.CapitalFixo = ObterCapitalFixo(cobertura);
                produtoCobertura.IndicarBeneficiario = cobertura.BeneficiariosPossiveis.Contains((int)TipoBeneficiarioPossivelEnum.BeneficiarioIndicado); /*verificar*/
                produtoCobertura.TaxaFixa = cobertura.TaxaFixa;
                produtoCobertura.EhServico = cobertura.EhServico;
                produtoCobertura.ValoresRepassadoAoCliente = cobertura.ValoresRepassadoAoCliente;
                produtoCobertura.ExibeServicoNaListaDeCobertura = cobertura.ExibeServicoNaListaDeCobertura;
                produtoCobertura.ClasseDeRiscoPadraoParaContratacao = cobertura.ClasseDeRiscoPadraoParaContratacao;
                produtoCobertura.Rendas = cobertura.Rendas;
                produtoCobertura.FormasContratacao = cobertura.FormasContratacao;
                produtoCobertura.CapitalSegurado = cobertura.TaxaFixa ? cobertura.ValorCapitalFixo.GetValueOrDefault() : 1000M;

                PreencherPrazoRenda(produtoApi, produtoCobertura, cobertura);
                PreencherPrazoCerto(produtoApi, produtoCobertura, cobertura);
                PreencherTipoRelacaoSegurado(produtoCobertura, cobertura);
                PreencherTipoCobertura(produtoCobertura, cobertura);
                PreencherCausas(produtoCobertura, cobertura, limites);
                PreencherProfissoesRecusadas(produtoApi, produtoCobertura, cobertura);
                PreencherUFsRecusadas(produtoApi, produtoCobertura, cobertura);
                PreencherFundos(produtoApi, produtoCobertura, cobertura);
                PreencherPrazoDecrescimo(produtoApi, produtoCobertura, cobertura);
                PreencherAntecipacao(produtoApi, produtoCobertura, cobertura);

                produtoApi.Coberturas.Add(produtoCobertura);
            }

            PreencherDependencias(produtoApi, produto, produtos);

            produtoApi.IndicarBeneficiario = produtoApi.Coberturas.Any(c => c.IndicarBeneficiario.HasValue && c.IndicarBeneficiario.Value);
            produtoApi.ExigeDPS = produtoApi.Coberturas.Any(c => c.ExigeDPS.HasValue && c.ExigeDPS.Value);
            produtoApi.IdadeMinima = produtoApi.Coberturas.Max(c => c.IdadeMinima);
            produtoApi.IdadeMaxima = produtoApi.Coberturas.Min(c => c.IdadeMaxima);
            produtoApi.IdadeExclusao = produtoApi.Coberturas.Min(c => c.IdadeExclusao);
            produtoApi.ProfissoesAceitas = produto.ProfissoesAceitas.Select(p => (int)p).ToList();

            return produtoApi;
        }

        /// <summary>
        /// Preenche os prazos de renda da cobertura e do produto
        /// Considera que o conjunto de prazos de renda do produto é a interseção dos prazos de renda das coberturas
        /// </summary>
        /// <param name="produtoApi"></param>
        /// <param name="produtoCobertura"></param>
        /// <param name="cobertura"></param>
        private void PreencherPrazoRenda(Model.Produto produtoApi, Cobertura produtoCobertura, Contrato.CoberturaProdutoNegociado cobertura)
        {
            produtoCobertura.PrazoRenda = new List<PrazoRenda>();
            if (cobertura.Rendas != null && cobertura.Rendas.Count > 0)
            {
                produtoCobertura.PrazoRenda = cobertura.Rendas.Where(r => r.PrazoInicial > 0 && r.PrazoFinal > 0).Select(p => new PrazoRenda() { Id = p.Tipo.Id, Descricao = p.Tipo.Descricao, ValorMinimo = p.PrazoInicial, ValorMaximo = p.PrazoFinal }).ToList(); /*verificar*/

                if (produtoCobertura.PrazoRenda.Count > 0)
                {
                    if (produtoApi.PrazoRenda.Count == 0)
                        produtoApi.PrazoRenda.AddRange(produtoCobertura.PrazoRenda);
                    else
                        produtoApi.PrazoRenda = produtoApi.PrazoRenda.Intersect(produtoCobertura.PrazoRenda).ToList();
                }
            }
        }

        /// <summary>
        /// Preenche os prazos de cobertura da cobertura e do produto
        /// Considera que o conjunto de prazos de cobertura do produto é a interseção dos prazos de cobertura das coberturas
        /// </summary>
        /// <param name="produtoApi">produto (Api)</param>
        /// <param name="produtoCobertura">cobertura (Api)</param>
        /// <param name="cobertura">cobertura (Esb)</param>
        private void PreencherPrazoCerto(Model.Produto produtoApi, Cobertura produtoCobertura, Contrato.CoberturaProdutoNegociado cobertura)
        {
            produtoCobertura.PrazoCerto = new List<int>();
            if (cobertura.PrazoDeCobertura != null && cobertura.PrazoDeCobertura.Count > 0)
            {
                produtoCobertura.PrazoCerto = cobertura.PrazoDeCobertura.Select(p => (int)p).ToList(); /*verificar*/

                if (produtoCobertura.PrazoCerto.Count > 0)
                {
                    if (produtoApi.PrazoCerto.Count == 0)
                        produtoApi.PrazoCerto.AddRange(produtoCobertura.PrazoCerto);
                    else
                        produtoApi.PrazoCerto = produtoApi.PrazoCerto.Intersect(produtoCobertura.PrazoCerto).ToList();
                }
            }
        }

        /// <summary>
        /// Preenche o tipo de relação com o segurado da cobertura
        /// </summary>
        /// <param name="produtoCobertura">cobertura (Api)</param>
        /// <param name="cobertura">cobertura (Esb)</param>
        private void PreencherTipoRelacaoSegurado(Cobertura produtoCobertura, Contrato.CoberturaProdutoNegociado cobertura)
        {
            produtoCobertura.TipoRelacaoSegurado = new Model.TipoRelacaoSegurado();
            produtoCobertura.TipoRelacaoSegurado.Id = cobertura.TipoRelacaoSegurado;
            produtoCobertura.TipoRelacaoSegurado.Descricao = ((TipoRelacaoSeguradoEnum)cobertura.TipoRelacaoSegurado).GetDescription();
        }

        /// <summary>
        /// Preenche as causas da cobertura
        /// </summary>
        /// <param name="produtoCobertura">cobertura (Api)</param>
        /// <param name="cobertura">cobertura (Esb)</param>
        /// <param name="limites">limites operacionais</param>
        private void PreencherCausas(Cobertura produtoCobertura, Contrato.CoberturaProdutoNegociado cobertura, List<Contrato.LimiteOperacionalPorFaixa> limites)
        {
            if (cobertura.CoberturaId != null)
            {
                produtoCobertura.Causas = limites.Where(l => l.CoberturasIds.Contains(cobertura.CoberturaId.Value))
                    .GroupBy(l => l.TipoGrupoCobertura).Select(g => new Causa { Descricao = g.Key }).ToList();
            }
        }

        /// <summary>
        /// Preenche o tipo de cobertura agrupado da Api
        /// </summary>
        /// <param name="produtoCobertura">cobertura (Api)</param>
        /// <param name="cobertura">cobertura (Esb)</param>
        private void PreencherTipoCobertura(Cobertura produtoCobertura, Contrato.CoberturaProdutoNegociado cobertura)
        {
            TipoCoberturaAgrupadoEnum? tipoCobertura = ObterTipoCobertura(cobertura);
            if (tipoCobertura != null)
            {
                produtoCobertura.Tipo = new TipoCobertura();
                produtoCobertura.Tipo.Id = (int?)tipoCobertura.Value;
                produtoCobertura.Tipo.Descricao = ((TipoCoberturaAgrupadoEnum)produtoCobertura.Tipo.Id).GetDescription();
            }
        }

        /// <summary>
        /// Preenche as dependências com os demais produtos
        /// </summary>
        /// <param name="produtoApi">produto (Api)</param>
        /// <param name="produto">produto (Esb)</param>
        /// <param name="produtos">produtos do modelo (Esb)</param>
        private void PreencherDependencias(Model.Produto produtoApi, Contrato.ProdutoNegociado produto, List<Contrato.ProdutoNegociado> produtos)
        {
            produtoApi.DependenciasProdutos = new List<DependenciaProduto>();
            foreach (Contrato.DependenciaProdutoNegociado dep in produto.Dependencias)
            {
                var dependencia = new DependenciaProduto
                {
                    ProdutoId = produtos.FirstOrDefault(p => p.Id == dep.ProdutoId)?.CodigoPlanoSysPrev,
                    Tipo = new TipoDependenciaProduto
                    {
                        Id = dep.TipoId,
                        Descricao = ((TipoDependenciaProdutoEnum)dep.TipoId).GetDescription()
                    }
                };

                produtoApi.DependenciasProdutos.Add(dependencia);
            }
        }

        /// <summary>
        /// Preenche os campos de antecipação (idade e tempo) da cobertura e do produto
        /// Considera que o conjunto valores de antecipação do produto é a interseção dos valores de antecipação das coberturas
        /// </summary>
        /// <param name="produtoApi">produto (Api)</param>
        /// <param name="produtoCobertura">cobertura (Api)</param>
        /// <param name="cobertura">cobertura (Esb)</param>
        private void PreencherAntecipacao(Model.Produto produtoApi, Cobertura produtoCobertura, Contrato.CoberturaProdutoNegociado cobertura)
        {
            produtoCobertura.IdadeAntecipacao = new List<int>();
            produtoCobertura.TempoAntecipacao = new List<int>();
            if (cobertura.AdiantamentoContribuicao != null && cobertura.AdiantamentoContribuicao.Count > 0)
            {
                var adiantamento = cobertura.AdiantamentoContribuicao.FirstOrDefault();
                produtoCobertura.IdadeAntecipacao = adiantamento?.Idade.Select(i => (int)i).ToList();
                produtoCobertura.TempoAntecipacao = adiantamento?.Prazo.Select(p => (int)p).ToList();

                if (produtoCobertura.IdadeAntecipacao != null && produtoCobertura.IdadeAntecipacao.Count > 0)
                {
                    if (produtoApi.IdadeAntecipacao.Count == 0)
                        produtoApi.IdadeAntecipacao.AddRange(produtoCobertura.IdadeAntecipacao);
                    else
                        produtoApi.IdadeAntecipacao = produtoApi.IdadeAntecipacao.Intersect(produtoCobertura.IdadeAntecipacao).ToList();
                }

                if (produtoCobertura.TempoAntecipacao != null && produtoCobertura.TempoAntecipacao.Count > 0)
                {
                    if (produtoApi.TempoAntecipacao.Count == 0)
                        produtoApi.TempoAntecipacao.AddRange(produtoCobertura.TempoAntecipacao);
                    else
                        produtoApi.TempoAntecipacao = produtoApi.TempoAntecipacao.Intersect(produtoCobertura.TempoAntecipacao).ToList();
                }
            }
        }

        /// <summary>
        /// Preenche os prazos de decréscimo da cobertura e do produto
        /// Considera que o conjunto de prazos de decréscimo do produto é a interseção dos prazos de decréscimo das coberturas
        /// </summary>
        /// <param name="produtoApi">produto (Api)</param>
        /// <param name="produtoCobertura">cobertura (Api)</param>
        /// <param name="cobertura">cobertura (Esb)</param>
        private void PreencherPrazoDecrescimo(Model.Produto produtoApi, Cobertura produtoCobertura, Contrato.CoberturaProdutoNegociado cobertura)
        {
            produtoCobertura.PrazoDecrescimo = new List<int>();
            if (cobertura.DecrescimoContribuicao != null && cobertura.DecrescimoContribuicao.Count > 0)
            {
                produtoCobertura.PrazoDecrescimo = cobertura.DecrescimoContribuicao.GroupBy(d => d.Prazo).Select(g => (int)g.Key).ToList();

                if (produtoCobertura.PrazoDecrescimo.Count > 0)
                {
                    if (produtoApi.PrazoDecrescimo.Count == 0)
                        produtoApi.PrazoDecrescimo.AddRange(produtoCobertura.PrazoDecrescimo);
                    else
                        produtoApi.PrazoDecrescimo = produtoApi.PrazoDecrescimo.Intersect(produtoCobertura.PrazoDecrescimo).ToList();
                }
            }
        }

        /// <summary>
        /// Preenche os fundos vinculados à cobertura e ao produto
        /// Considera que o conjunto de fundos do produto é a interseção dos fundos das coberturas
        /// </summary>
        /// <param name="produtoApi">produto (Api)</param>
        /// <param name="produtoCobertura">cobertura (Api)</param>
        /// <param name="cobertura">cobertura (Esb)</param>
        private void PreencherFundos(Model.Produto produtoApi, Cobertura produtoCobertura, Contrato.CoberturaProdutoNegociado cobertura)
        {
            produtoCobertura.Fundos = new List<Model.Fundo>();
            foreach (var fundo in cobertura.Fundos)
            {
                var fundoApi = new Model.Fundo();
                fundoApi.Id = fundo.Id;
                //fundoApi.Cnpj = não existe referência ao cnpj no serviço
                fundoApi.NomeFantasia = fundo.NomeFantasia;
                fundoApi.PercentualRendaVariavel = (float?)fundo.PercentualRendaVariavel;
                fundoApi.Sigla = fundo.Codigo;

                produtoCobertura.Fundos.Add(fundoApi);
            }

            if (produtoCobertura.Fundos.Count > 0)
            {
                if (produtoApi.Fundos.Count == 0)
                    produtoApi.Fundos.AddRange(produtoCobertura.Fundos);
                else
                    produtoApi.Fundos = produtoApi.Fundos.Intersect(produtoCobertura.Fundos).ToList();
            }
        }

        /// <summary>
        /// Preenche as profissões recusadas da cobertura e do produto
        /// Considera que o conjunto de profissões recusadas do produto é a união das profissões recusadas das coberturas
        /// </summary>
        /// <param name="produtoApi">produto (Api)</param>
        /// <param name="produtoCobertura">cobertura (Api)</param>
        /// <param name="cobertura">cobertura (Esb)</param>
        private void PreencherProfissoesRecusadas(Model.Produto produtoApi, Cobertura produtoCobertura, Contrato.CoberturaProdutoNegociado cobertura)
        {
            produtoCobertura.ProfissoesRecusadas = cobertura.ProfissoesRecusadasIds.Select(p => (int)p).ToList();

            if (produtoCobertura.ProfissoesRecusadas.Count > 0)
            {
                if (produtoApi.ProfissoesRecusadas.Count == 0)
                    produtoApi.ProfissoesRecusadas.AddRange(produtoCobertura.ProfissoesRecusadas);
                else
                    produtoApi.ProfissoesRecusadas = produtoApi.ProfissoesRecusadas.Union(produtoCobertura.ProfissoesRecusadas).ToList();
            }
        }

        /// <summary>
        /// Preenche as UFs recusadas da cobertura e do produto
        /// Considera que o conjunto de UFs recusadas do produto é a união das UFs recusadas das coberturas
        /// </summary>
        /// <param name="produtoApi">produto (Api)</param>
        /// <param name="produtoCobertura">cobertura (Api)</param>
        /// <param name="cobertura">cobertura (Esb)</param>
        private void PreencherUFsRecusadas(Model.Produto produtoApi, Cobertura produtoCobertura, Contrato.CoberturaProdutoNegociado cobertura)
        {
            produtoCobertura.UFsRecusadas = cobertura.UFsRecusadasIds.Select(uf => uf).ToList();
            if (produtoCobertura.UFsRecusadas.Count > 0)
            {
                if (produtoApi.UFsRecusadas.Count == 0)
                    produtoApi.UFsRecusadas.AddRange(produtoCobertura.UFsRecusadas);
                else
                    produtoApi.UFsRecusadas = produtoApi.UFsRecusadas.Union(produtoCobertura.UFsRecusadas).ToList();
            }
        }

        /// <summary>
        /// Obtém o valor fixo da cobertura repassado ao cliente, caso exista
        /// </summary>
        /// <param name="cobertura"></param>
        /// <returns>valor fixo ou null, caso não exista</returns>
        private float? ObterValorFixo(Contrato.CoberturaProdutoNegociado cobertura)
        {
            if (cobertura.ValoresRepassadoAoCliente != null && cobertura.ValoresRepassadoAoCliente.Count > 0)
            {
                return (float)cobertura.ValoresRepassadoAoCliente.Where(v => v != null && v.TipoRepasseCliente == TipoRepasseClienteEnum.Fixo).Sum(v => v.Valor); /*rever*/
            }           
            return null;
        }

        /// <summary>
        /// Obtém o valor de capital fixo, caso exista
        /// </summary>
        /// <param name="cobertura"></param>
        /// <returns>capital fixo ou null, caso não exista</returns>
        private float? ObterCapitalFixo(Contrato.CoberturaProdutoNegociado cobertura)
        {
            if (cobertura.ValorCapitalFixo != null)
                return (float)cobertura.ValorCapitalFixo;

            return null;
        }

        /// <summary>
        /// Obtém o tipo de cobertura agrupado de acordo com a classificação da Api
        /// </summary>
        /// <param name="cobertura">cobertura</param>
        /// <returns>true or false</returns>
        private TipoCoberturaAgrupadoEnum? ObterTipoCobertura(Contrato.CoberturaProdutoNegociado cobertura)
        {
            switch ((TipoCoberturaEnum)cobertura.Tipo)
            {
                case TipoCoberturaEnum.Vgbl:
                case TipoCoberturaEnum.Pgbl:
                    return TipoCoberturaAgrupadoEnum.Acumulacao;

                case TipoCoberturaEnum.Previdencia:
                    return TipoCoberturaAgrupadoEnum.Previdencia;

                case TipoCoberturaEnum.Seguro:
                case TipoCoberturaEnum.VidaIndividual:
                    return TipoCoberturaAgrupadoEnum.RiscoIndividual;

                case TipoCoberturaEnum.Servico:
                    if (CoberturaPossuiPreco(cobertura))
                        return TipoCoberturaAgrupadoEnum.ServicoPrecificado;
                    return TipoCoberturaAgrupadoEnum.Servico;

                case TipoCoberturaEnum.Emprestimo:
                    return TipoCoberturaAgrupadoEnum.Emprestimo;
                default:
                    return null;
            }
        }

        /// <summary>
        /// Verifica se uma cobertura possui valores repassados ao cliente
        /// </summary>
        /// <param name="cobertura">cobertura</param>
        /// <returns>true or false</returns>
        private bool CoberturaPossuiPreco(Contrato.CoberturaProdutoNegociado cobertura)
        {
            if (cobertura.ValoresRepassadoAoCliente != null && cobertura.ValoresRepassadoAoCliente.Count > 0)
            {
                return cobertura.ValoresRepassadoAoCliente.Where(v => v != null && v.TipoRepasseCliente == TipoRepasseClienteEnum.Fixo).Any(v => v.Valor > 0);
            }

            return false;
        }

        /// <summary>
        /// Indica se um item produto é do tipo renda vitalícia
        /// </summary>
        /// <param name="tipoId">id do tipo de renda</param>
        /// <returns>true or false</returns>
        private bool RendaPrazoCerto(int tipoId)
        {
            return tipoId == (int)TipoRendaEnum.PrazoCerto;

            /*verificar*/
            /*return tipoId == (int) TipoRendaEnum.Vitalicia ||
                   tipoId == (int) TipoRendaEnum.VitaliciaMinimoGarantido ||
                   tipoId == (int) TipoRendaEnum.VitaliciaReversivel ||
                   tipoId == (int) TipoRendaEnum.VitaliciaReversivelConjugeContinuidadeMenores ||
                   tipoId == (int) TipoRendaEnum.VitaliciaReversivelMinimoGarantido;*/
        }

        /// <summary>
        /// Obtém objeto com parâmetros de consulta da política de aceitação
        /// </summary>
        /// <param name="codigoModeloProposta">código do modelo de proposta</param>
        /// <returns></returns>
        private Contrato.PoliticaDeAceitacaoComVigencia ObterParametroPoliticaDeAceitacao(string codigoModeloProposta)
        {
            var politica = new Contrato.PoliticaDeAceitacaoComVigencia
            {
                CodigoModeloProposta = codigoModeloProposta,
                DataVigencia = DateTime.Now,
                Idade = 99,
                Renda = 10000,
                ProfissaoESimId = 1,
                Uf = "RJ"
            };

            return politica;
        }

        #endregion
    }
}
