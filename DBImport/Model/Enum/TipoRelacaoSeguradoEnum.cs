using System.ComponentModel;

namespace Api.Engines.Venda.Model.Enum
{
    public enum TipoRelacaoSeguradoEnum
    {   [Description("Titular")]
        Titular = 1,
        [Description("Cônjuge")]
        Conjuge = 2,
        [Description("Filhos")]
        Filhos = 3,
        [Description("Sinistrado")]
        Sinistrado = 4
    }
}
