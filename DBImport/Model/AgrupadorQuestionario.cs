using System.Collections.Generic;

namespace Api.Engines.Venda.Model
{
    public class AgrupadorQuestionario : ItemQuestionario
    {
        /// <summary>
        /// Gets or Sets Perguntas
        /// </summary>
      public List<ItemQuestionario> Perguntas { get; set; }
    }
}
