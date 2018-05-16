namespace Api.Engines.Venda.Model
{
    public class ItemQuestionario
    {
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        public int? Id { get; set; }
        /// <summary>
        /// Gets or Sets Descricao
        /// </summary>
        public string Descricao { get; set; }
        /// <summary>
        /// <summary>
        /// Gets or Sets TipoItemQuestionario
        /// </summary>
        public TipoItemQuestionario Tipo { get; set; }
        /// <summary>
        /// <summary>
        /// Gets or Sets Ordem
        /// </summary>
        public int? Ordem { get; set; }
    }
}
