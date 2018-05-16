using System.Collections.Generic;

namespace Api.Engines.Venda.Model
{
    public class PerguntaQuestionario : ItemQuestionario
    {
        /// <summary>
        /// Gets or Sets TipoResposta
        /// </summary>
        public TipoResposta TipoResposta { get; set; }
        /// <summary>
        /// Gets or Sets TipoVariacaoResposta
        /// </summary>
        public TipoVariacaoResposta TipoVariacaoResposta { get; set; }
        /// <summary>
        /// Gets or Sets Dominio
        /// </summary>
        public List<DominioResposta> Dominio { get; set; }
        /// <summary>
        /// Gets or Sets IdLegado
        /// </summary>
        public int? IdLegado { get; set; }
    }
}
