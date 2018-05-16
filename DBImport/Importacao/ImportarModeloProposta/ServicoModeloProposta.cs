using Api.Engines.Venda.Infra;
using Api.Engines.Venda.Infra.WcfProxies;
using Api.Engines.Venda.Model;
using Api.Engines.Venda.Model.Enum;
using Contrato = Mongeral.ESB.Produto.Contrato.v2.Dados;
using Mongeral.ESB.Produto.Contrato.v2.Operacoes;
using System;
using System.Collections.Generic;
using System.Linq;
using ModeloPropostaEsb = Mongeral.ESB.Produto.Contrato.v2.Dados.ModeloProposta;
using Api.Engines.Venda.Extensions;
namespace Api.Engines.Venda.Importacao.ImportarModeloProposta
{
    public class ServicoModeloProposta
    {
        protected Dictionary<string, List<Model.Questionario>> _questionarios;
        public ServicoModeloProposta()
        {
            _questionarios = MockQuestionario.CriarQuestionarios();
        }
        /// <summary>
        /// Obtém os modelos de proposta de um determinado CNPJ e/ou canal de venda
        /// </summary>
        /// <param name="cnpj"></param>
        /// <param name="canalVenda"></param>
        /// <returns></returns>
        public IQueryable<Model.ModeloProposta> ObterTodos(List<ModeloPropostaEsb> listaModeloProposta)
        {
            var modelos = new List<Model.ModeloProposta>();
            foreach (ModeloPropostaEsb modeloPropostaEsb in listaModeloProposta)
            {
                if (modeloPropostaEsb.StatusId != (int)StatusModeloProposta.Comercializado) /*filtrar na consulta*/
                    continue;

                Model.ModeloProposta modeloPropostaApi;
               
                modeloPropostaApi = ObterModeloPropostaCompletoApi(modeloPropostaEsb);
                
                modelos.Add(modeloPropostaApi);
            }

            return modelos.AsQueryable();
        }

        /// <summary>
        /// Obtém modelo de proposta com base nas informações do modelo de proposta do serviço (versão completa)
        /// </summary>
        /// <param name="modeloProposta">modelo de proposta</param>
        /// <returns>modelo de proposta preenchido</returns>
        private ModeloPropostaCompleto ObterModeloPropostaCompletoApi(ModeloPropostaEsb modeloProposta)
        {
            var modeloPropostaApi = new ModeloPropostaCompleto();
            modeloPropostaApi.Id = modeloProposta.Codigo;
            modeloPropostaApi.Nome = modeloProposta.Descricao;
            modeloPropostaApi.DataUltimaAlteracao = DateTime.Now; /*alterar*/

            var keyValueNamespace = ServiceWcf<IGerirProposta>.UseSync(ger => ger.BuscarSchemaNamespacePorModelo(modeloProposta.Codigo));
            modeloPropostaApi.Namespace = keyValueNamespace.Value;

            var keyValuePolitica = ServiceWcf<IGerirProposta>.UseSync(ger => ger.BuscarPolitica(modeloProposta.Codigo, DateTime.Now, EnumTipoPolitica.VALIDACAO));
            modeloPropostaApi.PoliticaValidacao = keyValuePolitica.Value;

            ServicoPoliticaAceitacao servicoPolitica = new ServicoPoliticaAceitacao();

            var resultadoPoliticaAceitacao = ServiceWcf<INegociacaoService>.UseSync(n => n.ObterLimitesOperacionais(new Contrato.ParametroLimitesOperacionais
            {
                CodigoModeloProposta = modeloProposta.Codigo,
                DataVigencia = DateTime.Now
            }));

            modeloPropostaApi.PoliticaAceitacao = servicoPolitica.ObterLimitesOperacionais(resultadoPoliticaAceitacao.Valor);
            modeloPropostaApi.TicketMinimo = (float) resultadoPoliticaAceitacao.Valor.MinimoContribuicaoClientesNovos;

            ServicoProduto servicoProduto = new ServicoProduto();
            var produtosFiltrados = modeloProposta.Produtos.Where(p => !p.EstahRestrito).ToList();

            modeloPropostaApi.Produtos = new List<Model.Produto>();
            foreach (Contrato.ProdutoNegociado produto in modeloProposta.Produtos.Where(p => !p.EstahRestrito))
            {
                modeloPropostaApi.DiasVencimento = ObterDiasVencimento(modeloPropostaApi.DiasVencimento, produto.RegraCobranca.DiasVencimento);
                var produtoFormasCobranca = produto.RegraCobranca.FormasDeCobranca.Select(f => f.FormaCobranca).ToList();
                modeloPropostaApi.FormasPagamento = ObterFormasPagamento(modeloPropostaApi.FormasPagamento, produtoFormasCobranca);
                var produtoPeriodicidadesInt = produto.RegraCobranca.Periodicidades.Select(p => (int)p).ToList();
                modeloPropostaApi.Periodicidades = ObterPeriodicidades(modeloPropostaApi.Periodicidades, produtoPeriodicidadesInt);

                var produtoApi = servicoProduto.ObterProduto(produto, resultadoPoliticaAceitacao.Valor.LimitesOperacionais, produtosFiltrados);
                modeloPropostaApi.Produtos.Add(produtoApi);
            }
            bool existeTipoConjuge = ExisteTipoProponenteConjuge(modeloProposta.Produtos);
            modeloPropostaApi.Questionarios = ObterQuestionariosCompleto(modeloProposta.Codigo, modeloProposta.Perguntas, existeTipoConjuge);

            PreencherInformacoesAdicionais(modeloProposta, modeloPropostaApi);

            return modeloPropostaApi;
        }

        private bool ExisteTipoProponenteConjuge(List<Contrato.ProdutoNegociado> produtos)
        {
            return produtos.Where(p => p.TipoProponente == (int)TipoRelacaoSeguradoEnum.Conjuge).Any();
        }

        private static void PreencherInformacoesAdicionais(ModeloPropostaEsb modeloProposta, Model.ModeloProposta modeloPropostaApi)
        {
            if (modeloProposta.CanalComercializacao != null)
            {
                modeloPropostaApi.CanalComercializacao = new Model.CanalComercializacao
                {
                    Id = modeloProposta.CanalComercializacao.TipoCanalComercializacaoId,
                    Descricao = modeloProposta.CanalComercializacao.Descricao
                };
            }

            if (modeloProposta.Grupo != null)
            {
                modeloPropostaApi.Grupo = new GrupoProposta
                {
                    Id = modeloProposta.Grupo.Id,
                    Descricao = modeloProposta.Grupo.Descricao
                };
            }
        }

        /// <summary>
        /// Obtém questionários por meio das perguntas do modelo de proposta
        /// </summary>
        /// <param name="perguntas">perguntas do modelo de proposta</param>
        /// <returns></returns>
        private List<Model.Questionario> ObterQuestionariosCompleto(string codigoModeloProposta, List<Contrato.Pergunta> Perguntas, bool existeTipoConjuge)
        {
            List<Model.Questionario> questionariosSelecionados = new List<Model.Questionario>();

            if (!_questionarios.ContainsKey(codigoModeloProposta))
                if (Perguntas.Any())
                    questionariosSelecionados = _questionarios["XXX"];
                else
                    return null;
            else
                questionariosSelecionados = _questionarios[codigoModeloProposta];

            return MockQuestionario.TratarQuestionarios(questionariosSelecionados, Perguntas, existeTipoConjuge);
        }
        

        /// <summary>
        /// Obtém dias de vencimento realizando a interseção com os dias de vencimento dos demais produtos
        /// </summary>
        /// <param name="modeloDiasVencimento">dias de vencimento do modelo de negócio</param>
        /// <param name="produtoDiasVencimento">dias de vencimento do produto</param>
        /// <returns></returns>
        private List<int> ObterDiasVencimento(List<int> modeloDiasVencimento, List<int> produtoDiasVencimento)
        {
            if (modeloDiasVencimento == null)
                return new List<int>(produtoDiasVencimento);

            return modeloDiasVencimento.Intersect(produtoDiasVencimento).ToList();
        }

        /// <summary>
        /// Obtém as formas de pagamento realizando a interseção com as formas de pagamento dos demais produtos
        /// </summary>
        /// <param name="modeloFormasPagamento">formas de pagamento do modelo de negócio</param>
        /// <param name="produtoFormasCobranca">formas de pagamento do produto</param>
        /// <returns></returns>
        private List<FormaPagamento> ObterFormasPagamento(List<FormaPagamento> modeloFormasPagamento, List<Mongeral.ESB.Produto.Contrato.v2.Enumerations.FormaCobrancaEnum> produtoFormasCobranca)
        {
            if (modeloFormasPagamento == null)
                return produtoFormasCobranca.Select(p => new FormaPagamento { Id = (int)p, Descricao = p.GetDescription() }).ToList();

            IEnumerable<int> produtoFormasCobrancaIds = produtoFormasCobranca.Select(p => (int)p);
            IEnumerable<int> modeloFormasPagamentoIds = modeloFormasPagamento.Where(m => m.Id.HasValue).Select(m => m.Id.Value);
            IEnumerable<int> listaIntersecao = modeloFormasPagamentoIds.Intersect(produtoFormasCobrancaIds);

            return listaIntersecao.Select(p => new FormaPagamento { Id = p, Descricao = ((FormaCobrancaEnum)p).GetDescription() }).ToList();
        }

        /// <summary>
        /// Obtém as periodicidades realizando a interseção com as periodicidades dos demais produtos
        /// </summary>
        /// <param name="modeloPeriodicidades">dias de vencimento do modelo de negócio</param>
        /// <param name="produtoPeriodicidades">dias de vencimento do produto</param>
        /// <returns></returns>
        private List<Periodicidade> ObterPeriodicidades(List<Periodicidade> modeloPeriodicidades, List<int> produtoPeriodicidades)
        {
            if (modeloPeriodicidades == null)
                return produtoPeriodicidades.Select(p => new Periodicidade { Id = p, Descricao = ((PeriodicidadeEnum)p).GetDescription() }).ToList();

            IEnumerable<int> modeloPeriodicidadeIds = modeloPeriodicidades.Where(m => m.Id.HasValue).Select(m => m.Id.Value);
            IEnumerable<int> listaIntersecao = modeloPeriodicidadeIds.Intersect(produtoPeriodicidades);

            return listaIntersecao.Select(p => new Periodicidade { Id = p, Descricao = ((PeriodicidadeEnum)p).GetDescription() }).ToList();
        }
    }
}
