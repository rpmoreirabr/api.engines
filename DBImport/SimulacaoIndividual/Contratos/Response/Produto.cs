using System.Collections.Generic;

namespace Api.Engines.Venda.SimulacaoIndividual.Contratos.Response
{
    public class Produto
    {
        public string Descricao { get; set; }
        public int? Id { get; set; }
        public bool? Obrigatorio { get; set; }
        public List<Cobertura> Coberturas { get; set; }
    }
}
