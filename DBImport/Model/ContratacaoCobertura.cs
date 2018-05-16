using Api.Engines.Venda.Model.Enum;
using System.Collections.Generic;

namespace Api.Engines.Venda.Model
{
    public class ContratacaoCobertura
    {
        public List<string> ModelosProposta { get; set; }
        public string Descricao { get; set; }
        public decimal CapitalSegurado { get; set; }
        public int IdItemProduto { get; set; }
        public int PrazoCerto { get; set; }
        public decimal Premio { get; set; }
        public TipoCobertura Tipo { get; set; }
        public short PrazoDecrescimo { get; set; }
        public short IdadePagamentoAntecipado { get; set; }
        public short TempoPrazoAntecipado { get; set; }
        public bool Obrigatorio { get; set; }
        public decimal CustoFixo { get; set; }
        public decimal CapitalBase { get; set; }
        public decimal PremioBase { get; set; }
        public string Causa { get; set; }
        public decimal Limite { get; set; }    
        public TipoCapitalBase TipoCapitalBase { get; set; }
        public TipoRelacaoSegurado TipoRelacaoSegurado { get; set; }
    }
}