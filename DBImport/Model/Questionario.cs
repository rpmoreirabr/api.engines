using System;
using System.Collections.Generic;

namespace Api.Engines.Venda.Model
{
    public class Questionario
    {
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        public int? Id { get; set; }
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        public string Descricao { get; set; }
        /// <summary>
        /// Data da última alteração no questionário
        /// </summary>
        public DateTime? DataUltimaAlteracao { get; set; }
        /// <summary>
        /// Gets or Sets Tipo
        /// </summary>
        public TipoQuestionario Tipo { get; set; }
        /// <summary>
        /// Gets or Sets Sexo
        /// </summary>
        public Sexo Sexo { get; set; }
        /// <summary>
        /// Gets or Sets RelacaoSegurado
        /// </summary>
        public TipoRelacaoSegurado RelacaoSegurado { get; set; }
        /// <summary>
        /// Gets or Sets Perguntas
        /// </summary>
        public List<ItemQuestionario> Perguntas { get; set; }
    }
}
