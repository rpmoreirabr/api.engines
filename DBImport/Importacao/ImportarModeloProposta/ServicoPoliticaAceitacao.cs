using Api.Engines.Venda.Infra;
using Api.Engines.Venda.Model;
using Mongeral.ESB.Produto.Contrato.v2.Dados;
using Mongeral.ESB.Produto.Contrato.v2.Operacoes;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Api.Engines.Venda.Importacao.ImportarModeloProposta
{
    public class ServicoPoliticaAceitacao
    {
        #region Métodos Públicos

        /// <summary>
        /// Obtém as políticas de aceitação de todas as propostas de um determinado CNPJ
        /// </summary>
        /// <param name="cnpj">CNPJ do parceiro</param>
        /// <param name="canalVenda">Canal de venda</param>
        /// <returns></returns>
        public IQueryable<PoliticaAceitacao> ObterTodos(long cnpj, short canalVenda)
        {
            var pesquisa = new PesquisaModelosDeProposta();
            pesquisa.Cnpj = cnpj;
            pesquisa.CanalDeVenda = canalVenda; /*verificar*/

            var resultadoPesquisarModelos = ServiceWcf<INegociacaoService>.UseSync(n => n.PesquisarModelosDeProposta(pesquisa));

            if (resultadoPesquisarModelos.HouveErrosDuranteProcessamento)
                throw new Exception(string.Join(", ", resultadoPesquisarModelos.Mensagens));

            var listaModeloProposta = resultadoPesquisarModelos.Valor;

            var politicas = new List<PoliticaAceitacao>();
            
            foreach (var modeloPropostaEsb in listaModeloProposta)
            {
                PoliticaAceitacao politicaAceitacao = ObterLimitesOperacionais(modeloPropostaEsb.Codigo);

                if (politicaAceitacao == null)
                    continue;

                politicas.Add(politicaAceitacao);
            }

            return politicas.AsQueryable();
        }

        /// <summary>
        /// Obtém um produto de um determinado modelo de proposta
        /// </summary>
        /// <param name="cnpj">CNPJ do parceiro</param>
        /// <param name="canalVenda">Canal de venda</param>
        /// <param name="id">Identificador da política de aceitação</param>
        /// <returns></returns>
        public PoliticaAceitacao ObterPorId(long cnpj, short canalVenda, string id)
        {
            return new PoliticaAceitacao();

            /*var parametroModeloProposta = new ModeloProposta();
            parametroModeloProposta.Codigo = codigoModeloProposta;

            ResultadoDaOperacao<ModeloProposta> resultadoModeloProposta = _clienteNegociacao.ObterModeloProposta(parametroModeloProposta);
            ModeloProposta modeloProposta = resultadoModeloProposta.Valor;

            PoliticaDeAceitacaoComVigencia parametroPoliticaAceitacao = ObterParametroPoliticaDeAceitacao(modeloProposta.Codigo);
            ResultadoDaOperacao<PoliticaDeAceitacaoComVigencia> resultadoPoliticaAceitacao =
                _clienteNegociacao.ObterPoliticaDeAceitacaoVigenteComLimitesOperacionais(parametroPoliticaAceitacao);
            PoliticaDeAceitacaoComVigencia politicaAceitacao = resultadoPoliticaAceitacao.Valor;
            List<LimiteOperacional> limites = politicaAceitacao.LimitesOperacionais;

            ProdutoNegociado produto = modeloProposta.Produtos.FirstOrDefault(p => p.Id == id);

            if (produto == null)
                throw new Exception("Produto não foi encontrado");

            ProdutoApi produtoApi = ObterProduto(produto, limites);

            return produtoApi;*/
        }

        #endregion

        #region Métodos Privados

        public PoliticaAceitacao ObterLimitesOperacionais(PoliticaDeAceitacao politica)
        {
            return ObterLimitesOperacionais(politica.CodigoModeloProposta, politica);
        }

        /// <summary>
        /// Constrói um objeto de produto para retorno com o resultado do serviço de produtos e limites
        /// </summary>
        /// <param name="codigoModeloProposta">Código do modelo de proposta</param>
        /// <param name="politicasIds"></param>
        /// <returns></returns>
        public PoliticaAceitacao ObterLimitesOperacionais(string codigoModeloProposta, PoliticaDeAceitacao politicaAceitacao = null)
        {         
            if (politicaAceitacao == null)
            {
                var parametroPoliticaAceitacao = ObterParametroLimitesOperacionais(codigoModeloProposta);
                var resultadoPoliticaAceitacao = ServiceWcf<INegociacaoService>.UseSync(n => n.ObterLimitesOperacionais(parametroPoliticaAceitacao));
                politicaAceitacao = resultadoPoliticaAceitacao.Valor;
            }

            var limites = politicaAceitacao.LimitesOperacionais;
            var politica = new PoliticaAceitacao();

            politica.DataUltimaAlteracao = politicaAceitacao.DataInicioVigencia;
            politica.CigarrosExame = politicaAceitacao.QtdeMaximaCigarrosExame;
            politica.CigarrosRecusa = politicaAceitacao.QtdeMaximaCigarrosRecusa;
            politica.ImcMaximoExame = (int)politicaAceitacao.IMCMaximoExame; /*verificar*/
            politica.ImcMaximoRecusa = (int)politicaAceitacao.IMCMaximoRecusa; /*verificar*/
            politica.ImcMinimoExame = (int)politicaAceitacao.IMCMinimoExame; /*verificar*/
            politica.ImcMinimoRecusa = (int)politicaAceitacao.IMCMinimoRecusa; /*verificar*/           

            politica.LimitesOperacionaisPorFaixaEtaria = new List<LimiteOperacionalFaixaEtaria>();
            politica.LimitesOperacionaisPorProfissao = new List<LimiteOperacionalProfissao>();
            politica.LimitesOperacionaisPorRenda = new List<LimiteOperacionalRenda>();
            foreach (var limite in limites)
            {
                IncluirLimites(limite, politica);
            }

            return politica;
        }

        private void IncluirLimites(LimiteOperacionalPorFaixa limite, PoliticaAceitacao politica)
        {
            foreach (var limitePorIdade in limite.LimitesPorIdade)
            {
                var politicaFaixaEtaria = new LimiteOperacionalFaixaEtaria();
                politicaFaixaEtaria.Causa = limite.TipoGrupoCobertura;
                politicaFaixaEtaria.Coberturas = limite.CoberturasIds;
                politicaFaixaEtaria.ValorMaximoCapitalSegurado = (int)limitePorIdade.Limite; 
                politicaFaixaEtaria.IdadeInicial = limitePorIdade.IdadeInicial; 
                politicaFaixaEtaria.IdadeFinal = limitePorIdade.IdadeFinal; 
                politica.LimitesOperacionaisPorFaixaEtaria.Add(politicaFaixaEtaria);
            }

            foreach (var limitePorProfissao in limite.LimitesPorProfissoes)
            {

                var politicaProfissao = new LimiteOperacionalProfissao();
                politicaProfissao.Causa = limite.TipoGrupoCobertura;
                politicaProfissao.Coberturas = limite.CoberturasIds;
                politicaProfissao.ValorMaximoCapitalSegurado = (int)limitePorProfissao.Limite;
                politicaProfissao.ProfissoesId = limitePorProfissao.ProfissoesEsimId;
                politica.LimitesOperacionaisPorProfissao.Add(politicaProfissao);

            }

            foreach (var limitePorRenda in limite.LimitesPorRenda)
            {
                var politicaRenda = new LimiteOperacionalRenda();
                politicaRenda.Coberturas = limite.CoberturasIds;
                politicaRenda.Causa = limite.TipoGrupoCobertura;
                politicaRenda.IdadeInicial = limitePorRenda.IdadeInicial;
                politicaRenda.IdadeFinal = limitePorRenda.IdadeFinal;
                politicaRenda.MultiploRenda = (int)limitePorRenda.MultiploRenda; 
                politica.LimitesOperacionaisPorRenda.Add(politicaRenda);

            }
        }

        /// <summary>
        /// Obtém objeto com parâmetros de consulta da política de aceitação
        /// </summary>
        /// <param name="codigoModeloProposta">código do modelo de proposta</param>
        /// <returns></returns>
        private ParametroLimitesOperacionais ObterParametroLimitesOperacionais(string codigoModeloProposta)
        {
            var politica = new ParametroLimitesOperacionais();
            politica.CodigoModeloProposta = codigoModeloProposta;
            politica.DataVigencia = DateTime.Now;

            return politica;
        }

        #endregion
    }
}
