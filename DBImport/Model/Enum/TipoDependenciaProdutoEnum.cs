using System.ComponentModel;

namespace Api.Engines.Venda.Model.Enum
{
    public enum TipoDependenciaProdutoEnum
    {
        [Description("Contratação")]
        Contratacao = 1,
        [Description("Cancelamento")]
        Cancelamento = 2,
        [Description("Contratacao Exclusiva")]
        ContratacaoExclusiva = 3
    }
}
