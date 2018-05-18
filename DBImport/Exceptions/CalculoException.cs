using System;

namespace Api.Engines.Venda.Exceptions
{
    public class CalculoException : Exception
    {
        public Model.Observacao Observacao { get; private set; }
        public CalculoException()
            : base()
        {
        }
        public CalculoException(string mensagem)
            : base(mensagem)
        {

        }
        public CalculoException(string mensagem, Exception innerException)
            : base(mensagem, innerException)
        {

        }
        public CalculoException(Model.Observacao observacao)
            : base(observacao.Descricao)
        {
            Observacao = observacao;
        }
    }
}
