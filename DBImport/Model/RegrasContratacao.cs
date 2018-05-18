using System.Collections.Generic;

namespace Api.Engines.Venda.Model
{
    public class RegrasContratacao
    {
        public List<ContratacaoProduto> Produtos { get; set; }
        public decimal TicketMinimo { get; set; }
        public List<Observacao> Observacoes { get; set; }
    }
}
