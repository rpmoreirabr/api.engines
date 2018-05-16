using System.Collections.Generic;

namespace Api.Engines.Venda.Model
{
    public class LimiteOperacionalFaixaEtaria : Limite
    {
        public int? IdadeInicial { get; set; }
        public int? IdadeFinal { get; set; }
        public int? ValorMaximoCapitalSegurado { get; set; }
    }
}
