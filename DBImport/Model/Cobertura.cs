using Mongeral.ESB.Produto.Contrato.v2.Dados;
using System.Collections.Generic;

namespace Api.Engines.Venda.Model
{
    public class Cobertura
    {
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        public int? Id { get; set; }
        public int? IdEsim { get; set; }

        public short? IdCoberturaEsim { get; set; }
        /// <summary>
        /// Gets or Sets Descricao
        /// </summary>
        public string Descricao { get; set; }
        /// <summary>
        /// Gets or Sets DescricaoComercial
        /// </summary>
        public string DescricaoComercial { get; set; }
        /// <summary>
        /// Gets or Sets Obrigatoria
        /// </summary>
        public bool? Obrigatoria { get; set; }
        /// <summary>
        /// Gets or Sets PrazoCerto
        /// </summary>
        public List<int> PrazoCerto { get; set; }
        /// <summary>
        /// Gets or Sets PrazoRenda
        /// </summary>
        public List<PrazoRenda> PrazoRenda { get; set; }
        /// <summary>
        /// Gets or Sets Tipo
        /// </summary>
        public TipoCobertura Tipo { get; set; }
        /// <summary>
        /// Gets or Sets TipoRelacaoSegurado
        /// </summary>
        public TipoRelacaoSegurado TipoRelacaoSegurado { get; set; }
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
        /// Gets or Sets ValorFixo
        /// </summary>
        public float? ValorFixo { get; set; }
        /// <summary>
        /// Gets or Sets CapitalFixo
        /// </summary>
        public float? CapitalFixo { get; set; }
        /// <summary>
        /// Gets or Sets Causa
        /// </summary>
        public List<Causa> Causas { get; set; }
        /// <summary>
        /// Gets or Sets CoberturaPrincipal
        /// </summary>
        public bool? CoberturaPrincipal { get; set; }
        /// <summary>
        /// Gets or Sets ExigeDPS
        /// </summary>
        public bool? ExigeDPS { get; set; }
        /// <summary>
        /// Gets or Sets Fundos
        /// </summary>
        public List<Fundo> Fundos { get; set; }
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

        public bool TaxaFixa { get; set; }

        public bool EhServico { get; set; }

        public bool ValorServicoSomadoNaCoberturaDeReferencia { get; set; }
        public List<ValorRepassadoAoCliente> ValoresRepassadoAoCliente { get; set; }
        public bool ExibeServicoNaListaDeCobertura { get; set; }
        public ClasseRisco ClasseDeRiscoPadraoParaContratacao { get; set; }

        public decimal CapitalSegurado { get; set; }
        public decimal Premio { get; set; }
        public List<Renda> Rendas { get; set; }
        public List<FormaContratacao> FormasContratacao { get; set; }
    }
}
