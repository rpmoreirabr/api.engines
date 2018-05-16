namespace Api.Engines.Venda.Model
{
    public class DependenciaProduto
    {
        /// <summary>
        /// Gets or Sets ProdutoId
        /// </summary>
        public int? ProdutoId { get; set; }
        /// <summary>
        /// Gets or Sets Tipo
        /// </summary>
        public TipoDependenciaProduto Tipo { get; set; }
    }
}
