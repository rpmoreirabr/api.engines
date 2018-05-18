using System.Collections.Generic;

namespace Api.Engines.Venda.SimulacaoIndividual.Contratos.Request
{

    public class Produto {
    public int? Id { get; set; }

    public List<Cobertura> Coberturas { get; set; }
  }
}
