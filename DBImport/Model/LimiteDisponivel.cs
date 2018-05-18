using System.Collections.Generic;

namespace Api.Engines.Venda.Model
{
    public class LimiteDisponivel
    {
        public string Causa { get; set; }
        public List<ContratacaoProduto> Produtos { get; set; }
        public decimal ValorMaximo { get; set; }
    }
}
