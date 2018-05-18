using System;
using System.Collections.Generic;

namespace Api.Engines.Venda.SimulacaoIndividual.Contratos.Response
{

    public class Response
    {
        public Response ()
        {
            id = Guid.NewGuid().ToString();
        }
        public string id { get; set; }
        public Api.Engines.Venda.SimulacaoIndividual.Contratos.Request.Request Request { get; set; }
        public List<Produto> Produtos { get; set; }
        public decimal TicketMinimo { get; set; }
    }
}
