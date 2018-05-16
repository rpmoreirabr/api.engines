using System.Collections.Generic;

namespace Api.Engines.Venda.Model
{
    public class LimiteOperacionalProfissao : Limite
    {
        public List<short> ProfissoesId { get; set; }
        public decimal? ValorMaximoCapitalSegurado { get; set; }
    }
}
