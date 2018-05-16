using System;
using System.Collections.Generic;

namespace Api.Engines.Venda.Model
{
    public class Observacao
    {
        public long ID { get; set; }
        public string Descricao { get; set; }
        private List<string> _itens;
        public List<string> Itens
        {
            get { return _itens ?? new List<string>(); }
            set { _itens = value; }
        }
        public string Origem { get; set; }

        public Observacao(long id = 0, string descricao = null, string origem = null)
        {
            ID = id;
            Descricao = descricao;
            Origem = origem;
        }
    }
}