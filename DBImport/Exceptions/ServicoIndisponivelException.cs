using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Engines.Venda.Exceptions
{
    public class ServicoIndisponivelException : Exception
    {
        public Model.Observacao Observacao { get; private set; }

        public ServicoIndisponivelException()
            : base() { }

        public ServicoIndisponivelException(Model.Observacao observacao)
            : base(observacao.Descricao)
        {
            Observacao = observacao;
        }
    }
}
