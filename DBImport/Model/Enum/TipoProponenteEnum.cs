using System.ComponentModel;

namespace Api.Engines.Venda.Model.Enum
{
    public enum TipoProponenteEnum
    {
        [Description("Titular")]
        Titular = 1,
        [Description("Cônjuge")]
        Conjuge = 2,
        [Description("Filho")]
        Filho = 3
    }
}
