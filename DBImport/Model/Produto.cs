using System;
using System.Collections.Generic;

namespace Api.Engines.Venda.Model
{
    public class Produto
    {
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        public int? Id { get; set; }
        public int? IdEsim { get; set; }
        public string Descricao { get; set; }
        /// <summary>
        /// Gets or Sets DescricaoComercial
        /// </summary>
        public string DescricaoComercial { get; set; }
        /// <summary>
        /// Data da última alteração no produto.
        /// </summary>
        /// <value>Data da última alteração no produto.</value>
        public DateTime? DataUltimaAlteracao { get; set; }
        /// <summary>
        /// Gets or Sets Coberturas
        /// </summary>
        public List<Cobertura> Coberturas { get; set; }
        /// <summary>
        /// Gets or Sets DependenciasProdutos
        /// </summary>
        public List<DependenciaProduto> DependenciasProdutos { get; set; }
        /// <summary>
        /// Gets or Sets Fundos
        /// </summary>
        public List<Fundo> Fundos { get; set; }
        /// <summary>
        /// Lista com as possíveis periodicidades de pagamento.
        /// </summary>
        /// <value>Lista com as possíveis periodicidades de pagamento.</value>
        public List<Periodicidade> Periodicidades { get; set; }
        /// <summary>
        /// Gets or Sets TipoProponente
        /// </summary>
        public TipoProponente TipoProponente { get; set; }
        /// <summary>
        /// Gets or Sets IdadeMinima
        /// </summary>
        public int? IdadeMinima { get; set; }
        /// <summary>
        /// Gets or Sets IdadeMaxima
        /// </summary>
        public int? IdadeMaxima { get; set; }
        /// <summary>
        /// Gets or Sets IdadeExclusao
        /// </summary>
        public int? IdadeExclusao { get; set; }
        /// <summary>
        /// Gets or Sets IndicarBeneficiario
        /// </summary>
        public bool? IndicarBeneficiario { get; set; }
        /// <summary>
        /// Gets or Sets ExigeDPS
        /// </summary>
        public bool? ExigeDPS { get; set; }
        /// <summary>
        /// Gets or Sets PrazoCerto
        /// </summary>
        public List<int> PrazoCerto { get; set; }
        /// <summary>
        /// Gets or Sets PrazoRenda
        /// </summary>
        public List<PrazoRenda> PrazoRenda { get; set; }
        /// <summary>
        /// Gets or Sets ProfissoesAceitas
        /// </summary>
        public List<int> ProfissoesAceitas { get; set; }
        /// <summary>
        /// Gets or Sets ProfissoesRecusadas
        /// </summary>
        public List<int> ProfissoesRecusadas { get; set; }
        /// <summary>
        /// Gets or Sets UFsRecusadas
        /// </summary>
        public List<string> UFsRecusadas { get; set; }
        /// <summary>
        /// Gets or Sets PrazoDecrescimo
        /// </summary>
        public List<int> PrazoDecrescimo { get; set; }
        /// <summary>
        /// Gets or Sets IdadeAntecipacao
        /// </summary>
        public List<int> IdadeAntecipacao { get; set; }
        /// <summary>
        /// Gets or Sets TempoAntecipacao
        /// </summary>
        public List<int> TempoAntecipacao { get; set; }
        public bool EstahRestrito { get; set; }
        public bool Obrigatorio { get; set; }

        public short? ReferenciaCoberturaId { get; set; }
    }
}
