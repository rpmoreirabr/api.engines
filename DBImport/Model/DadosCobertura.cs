namespace Api.Engines.Venda.Model
{
    public class DadosCobertura
    {
        public int CodigoPlano { get; set; }
        public int CodigoCobertura { get; set; }
        public decimal ValorBeneficio { get; set; }
        public decimal ValorContribuicao { get; set; }
        public decimal ValorChave { get; set; }
        public short Sexo { get; set; }
        public bool Conjuge { get; set; }
        public int IdadeInicio { get; set; }
        public int IdadeFim { get; set; }
        public int CodigoComposicao { get; set; }
    }
}
