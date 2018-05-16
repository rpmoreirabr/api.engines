using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Engines.Venda.Model
{
    public class Simulacao<T>
    {
        public T Valor { get; set; }
        public List<Observacao> Observacoes { get; set; }
    }
}
