using Api.Engines.Venda.Model;
using System;

namespace Api.Engines.Venda.Exceptions
{
    public class ProdutoException : Exception
    {
        public Observacao Observacao { get; private set; }
        public ProdutoException()
            : base()
        {
        }
        public ProdutoException(Observacao observacao)
            : base(observacao.Descricao)
        {
            Observacao = observacao;
        }
    }
}
