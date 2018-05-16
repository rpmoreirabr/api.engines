using System.ComponentModel;

namespace Api.Engines.Venda.Model.Enum
{
    public enum TipoBeneficiarioPossivelEnum
    {
        [Description("Beneficiário Indicado")]
        BeneficiarioIndicado = 1,
        [Description("Titular")]
        Titular = 2,
        [Description("Cônjuge")]
        Conjuge = 3,        
        [Description("Filhos")]
        Filhos = 4,
        [Description("Cônjuge e Filhos")]
        ConjugeFilhos = 5,
        [Description("EFPC (Fundo de Pensão)")]
        Efpc = 6,
        [Description("Sem Indicação de Beneficiário")]
        SemIndicacaoBeneficiario = 7
    }
}
