namespace Api.Engines.Venda.Model
{
    public class Fundo
    {
        /// <summary>
        /// Gets or Sets Id
        /// </summary>      
        public int? Id { get; set; }
        /// <summary>
        /// Gets or Sets Cnpj
        /// </summary>
        public string Cnpj { get; set; }
        /// <summary>
        /// Gets or Sets Sigla
        /// </summary>
        public string Sigla { get; set; }
        /// <summary>
        /// Gets or Sets NomeFantasia
        /// </summary>
        public string NomeFantasia { get; set; }
        /// <summary>
        /// Gets or Sets PercentualRendaVariavel
        /// </summary>
        public float? PercentualRendaVariavel { get; set; }
    }
}
