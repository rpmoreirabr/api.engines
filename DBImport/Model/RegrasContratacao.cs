using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Engines.Venda.Model
{
    public class RegrasContratacao
    {
        public List<ContratacaoProduto> Produtos { get; set; }
        public decimal TicketMinimo { get; set; }
        public List<Observacao> Observacoes { get; set; }
    }
}
