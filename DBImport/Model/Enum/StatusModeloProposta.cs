using System.ComponentModel;

namespace Api.Engines.Venda.Model.Enum
{
    public enum StatusModeloProposta
    {
        [Description("Comercializado")]
        Comercializado = 1,

        [Description("Não Comercializado")]
        NaoComercializado = 2,

        [Description("Em Desenvolvimento")]
        EmDesenvolvimento = 3
    }
}
