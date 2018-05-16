using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Engines.Venda.Model
{
    public class ObservacaoHelper
    {
        public static List<Observacao> UnirListasObservacao(List<Observacao> list, params List<Observacao>[] others)
        {
            if (others == null || others.Length < 1)
                return list;

            foreach (var listas in others)
                list.AddRange(listas);

            var r = new List<Observacao>();
            foreach (var l1 in list)
            {
                foreach (var l2 in list)
                    if (IsEqual(l1, l2))
                        l1.Itens = UnirItensUnicos(l1.Itens, l2.Itens);
                r.Add(l1);
            }

            return RemoverDuplicatas(r);
        }

        private static List<Observacao> RemoverDuplicatas(List<Observacao> list)
        {
            for (var i = 0; i < list.Count; i++)
            {
                var l1 = list[i];
                if (list.Count(x => IsEqual(l1, x)) > 1)
                    list.RemoveAt(i--);
            }
            return list;
        }

        private static bool IsEqual(Observacao obs1, Observacao obs2)
        {
            return obs1.Descricao == obs2.Descricao && obs1.ID == obs2.ID && obs1.Origem == obs2.Origem;
        }

        private static List<string> UnirItensUnicos(List<string> list, List<string> listToAdd)
        {
            var r = list;
            foreach (var s in listToAdd)
            {
                if (!r.Contains(s))
                    r.Add(s);
            }
            return r;
        }

        public static Observacao PreencherObservacao(long id, string descricao = null, string origem = null)
        {
            return PreencherObservacao(id, descricao, origem, null);
        }

        public static Observacao PreencherObservacao(long id, string descricao = null, string origem = null, params string[] itens)
        {
            var i = new List<string>();
            if (itens != null)
                i.AddRange(itens);

            return PreencherObservacao(new Observacao(id)
            {
                Itens = i,
                Descricao = descricao,
                Origem = origem
            });
        }

        public static Observacao PreencherObservacao(Observacao obs)
        {
            if (string.IsNullOrWhiteSpace(obs.Descricao))
                obs.Descricao = StringDescricoes(obs.ID, obs.Descricao);

            return obs;
        }

        private static string StringDescricoes(long id, string def = null)
        {
            switch (id)
            {
                case 1:
                    return "Não foi possível validar os limites operacionais.";
                case 2:
                    return "Alguns produtos foram excluídos por não serem possíveis de comercialização para o perfil informado.";
                case 3:
                    return "Não foi possível validar os produtos disponíveis para o perfil.";
                case 4: //TODO: Esquema para passar parâmetros e formatar string aqui
                    return "Limite excedido.";
                case 5:
                    return "É obrigatório o preenchimento do CapitalSegurado ou Prêmio.";
                case 6:
                    return "Não foi possível calcular o capital/prêmio porque os serviços de suporte se encontram offline.";
                default:
                    return def;
            }
        }
    }
}
