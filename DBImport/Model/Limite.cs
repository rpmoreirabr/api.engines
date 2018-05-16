using System.Collections.Generic;

namespace Api.Engines.Venda.Model
{
    public class Limite
    {
        public string Causa { get; set; }
        public IEnumerable<short> Coberturas { get; set; }
    }
}