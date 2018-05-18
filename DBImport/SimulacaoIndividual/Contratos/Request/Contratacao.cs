using System.Collections.Generic;

namespace Api.Engines.Venda.SimulacaoIndividual.Contratos.Request
{


    public class Contratacao {
    
    public string ModeloProposta { get; set; }
    public List<Produto> Produtos { get; set; }
    public List<Parametro> Parametros { get; set; }
  }
}
