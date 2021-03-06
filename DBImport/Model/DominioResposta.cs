﻿using System.Collections.Generic;

namespace Api.Engines.Venda.Model
{
    public class DominioResposta
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
        /// Gets or Sets SubPerguntas
        /// </summary>
        public List<PerguntaQuestionario> SubPerguntas { get; set; }
    }
}
