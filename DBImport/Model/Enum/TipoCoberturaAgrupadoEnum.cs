using System.ComponentModel;

namespace Api.Engines.Venda.Model.Enum
{
    public enum TipoCoberturaAgrupadoEnum
    {
        [Description("Acumulação")]
        Acumulacao = 1,
        [Description("Previdência")]
        Previdencia = 2,
        [Description("Risco Individual")]
        RiscoIndividual = 3,
        [Description("Risco Vida em Grupo")]
        RiscoGrupo = 4,
        [Description("Serviço")]
        Servico = 5,
        [Description("Serviço Precificado")]
        ServicoPrecificado = 6,
        [Description("Empréstimo")]
        Emprestimo = 7
    }
}
