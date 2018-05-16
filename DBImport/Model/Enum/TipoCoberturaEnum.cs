using System.ComponentModel;

namespace Api.Engines.Venda.Model.Enum
{
    public enum TipoCoberturaEnum
    {
        [Description("Não informado")]
        Nao_Informado = 0,
        [Description("Previdência")]
        Previdencia = 1,
        [Description("PGBL")]
        Pgbl = 2,
        [Description("Seguro")]
        Seguro = 3,
        [Description("VGBL")]
        Vgbl = 4,
        [Description("Serviço")]
        Servico = 5,
        [Description("Empréstimo")]
        Emprestimo = 6,
        [Description("Vida Individual")]
        VidaIndividual = 7
    }
}
