using System.ComponentModel;

namespace Api.Engines.Venda.Model.Enum
{
    public enum TipoVariacaoRespostaEnum
    {
        [Description("Seleção Única")]
        SelecaoUnica = 1,
        [Description("Multi-seleção")]
        MultiSelecao = 2
    }
}
