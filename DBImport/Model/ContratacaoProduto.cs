using System.Collections.Generic;

namespace Api.Engines.Venda.Model
{
    public class ContratacaoProduto
    {
        public string Descricao { get; set; }
        public int IdProduto { get; set; }
        public bool Obrigatorio { get; set; }
        public List<ContratacaoCobertura> CoberturasLimite { get; set; }
    }
}
