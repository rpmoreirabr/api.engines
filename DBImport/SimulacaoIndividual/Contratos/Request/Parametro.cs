using System;

namespace Api.Engines.Venda.SimulacaoIndividual.Contratos.Request
{


    public class Parametro
    {
        private enum TipoParametro
        {
            Periodicidade,
            PrazoDecrescimo,
            IdadePagamentoAntecipado,
            TempoPrazoAntecipado,
            PrazoCerto
        }

        public string Nome { get; set; }
        public short? Valor { get; set; }

        public static bool IsPeriodicidade(Parametro p)
        {
            return IsTipo(p, TipoParametro.Periodicidade); 
        }
        public static bool IsPrazoDecrescimo(Parametro p)
        {
            return IsTipo(p, TipoParametro.PrazoDecrescimo);
        }
        public static bool IsIdadePagamentoAntecipado(Parametro p)
        {
            return IsTipo(p, TipoParametro.IdadePagamentoAntecipado);
        }
        public static bool IsTempoPrazoAntecipado(Parametro p)
        {
            return IsTipo(p, TipoParametro.TempoPrazoAntecipado);
        }
        public static bool IsPrazoCerto(Parametro p)
        {
            return IsTipo(p, TipoParametro.PrazoCerto);
        }

        private static bool IsTipo(Parametro p, TipoParametro tipo)
        {
            return p.Nome.ToLower() == Enum.GetName(typeof(TipoParametro), tipo).ToLower();
        }
    }
}
