using System;
using System.Collections.Generic;

namespace Api.Engines.Venda.Model
{
    /// <summary>
    /// ...
    /// </summary>
    public class ModeloProposta
    {
        /// <summary>
        /// Código do Modelo de Proposta atribuído ao modelo de negócio.
        /// </summary>
        /// <value>Código do Modelo de Proposta atribuído ao modelo de negócio.</value>
        public string Id { get; set; }
        public string Nome { get; set; }
        /// <summary>
        /// Data da última alteração no modelo de proposta.
        /// </summary>
        /// <value>Data da última alteração no modelo de proposta.</value>
        public DateTime? DataUltimaAlteracao { get; set; }
        /// <summary>
        /// Namespace do schema conforme configurado no Gerenciador de Propostas.
        /// </summary>
        /// <value>Namespace do schema conforme configurado no Gerenciador de Propostas.</value>
        public string Namespace { get; set; }
        /// <summary>
        /// Formas de pagamento aceitas para este modelo de negócio.
        /// </summary>
        /// <value>Formas de pagamento aceitas para este modelo de negócio.</value>
        public List<FormaPagamento> FormasPagamento { get; set; }
        /// <summary>
        /// Possíveis dias de vencimento para o modelo de negócio.
        /// </summary>
        /// <value>Possíveis dias de vencimento para o modelo de negócio.</value>
        public List<int> DiasVencimento { get; set; }
        /// <summary>
        /// Lista com as possíveis periodicidades de pagamento.
        /// </summary>
        /// <value>Lista com as possíveis periodicidades de pagamento.</value>
        public List<Periodicidade> Periodicidades { get; set; }
        /// <summary>
        /// Valor mínimo de contratação do modelo de negócio.
        /// </summary>
        /// <value>Valor mínimo de contratação do modelo de negócio.</value>
        public float? TicketMinimo { get; set; }
        /// <summary>
        /// Código da política de validação vigente.
        /// </summary>
        /// <value>Código da política de validação vigente.</value>
        public string PoliticaValidacao { get; set; }

        /// <summary>
        /// Tipo de canal de comercialização da proposta, por exemplo Mobile, Loja Parceiro.
        /// </summary>
        /// <value>Tipo de canal de comercialização da proposta.</value>
        public CanalComercializacao CanalComercializacao { get; set; }

        /// <summary>
        /// Grupo de modelo de proposta, por exemplo, Vida Toda, Private Solutions.
        /// </summary>
        /// <value>Grupo de modelo de proposta</value>
        public GrupoProposta Grupo { get; set; }
    }
}