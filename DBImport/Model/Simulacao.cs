using System.Collections.Generic;

namespace Api.Engines.Venda.Model
{
    public class Simulacao<T>
    {
        public T Valor { get; set; }
        public List<Observacao> Observacoes { get; set; }
    }
}
