namespace Api.Engines.Venda.SimulacaoIndividual.Contratos.Response
{

    public class Cobertura
    {
        public int? Id { get; set; }
        public string Descricao { get; set; }
        public bool? Obrigatorio { get; set; }
        public decimal? Limite { get; set; }
        public string Causa { get; set; }
        public decimal? PremioBase { get; set; }
        public decimal? CapitalBase { get; set; }
        public string TipoCapitalBase { get; set; }
        public string TipoRelacaoSegurado { get; set; }
        public string TipoCobertura { get; set; }

    }
}
