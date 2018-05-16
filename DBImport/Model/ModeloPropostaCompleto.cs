using System.Collections.Generic;

namespace Api.Engines.Venda.Model
{
    public class ModeloPropostaCompleto : ModeloProposta
    {
        /// <summary>
        /// Gets or Sets Produtos
        /// </summary>
        public List<Produto> Produtos { get; set; }
        /// <summary>
        /// Gets or Sets PoliticaAceitacao
        /// </summary>
        public PoliticaAceitacao PoliticaAceitacao { get; set; }
        /// <summary>
        /// Gets or Sets Questionarios
        /// </summary>
        public List<Questionario> Questionarios { get; set; }
    }
}
