using System.ComponentModel;

namespace Api.Engines.Venda.Model.Enum
{
    public enum TipoRespostaEnum
    {
        [Description("Sim ou Não")]
        SimNao = 1,
        [Description("Texto Livre")]
        TextoLivre = 2,
        [Description("Valor")]
        Valor = 3,
        [Description("Domínio")]
        Dominio = 4
    }
}
