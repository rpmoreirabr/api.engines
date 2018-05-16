using System.ComponentModel;

namespace Api.Engines.Venda.Model.Enum
{
    public enum PeriodicidadeEnum
    {
        [Description("Única")]
        Unica = 0,
        [Description("Diária")]
        Diaria = 1,
        [Description("Esporádica")]
        Esporadica = 2,
        [Description("Semanal")]
        Semanal = 7,
        [Description("Quinzenal")]
        Quinzenal = 15,
        [Description("Mensal")]
        Mensal = 30,
        [Description("Bimestral")]
        Bimestral = 60,
        [Description("Trimestral")]
        Trimestral = 90,
        [Description("Quadrimestral")]
        Quadrimestral = 120,
        [Description("Semestral")]
        Semestral = 180,
        [Description("Anual")]
        Anual = 365
    }
}
