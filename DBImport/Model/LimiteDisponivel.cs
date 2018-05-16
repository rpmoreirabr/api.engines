using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Engines.Venda.Model
{
    public class LimiteDisponivel
    {
        public string Causa { get; set; }
        public List<ContratacaoProduto> Produtos { get; set; }
        public decimal ValorMaximo { get; set; }
    }
}
