using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using PerguntasDps = Mongeral.ESB.Produto.Contrato.v2.Dados;
using Api.Engines.Venda.Extensions;
using Api.Engines.Venda.Model.Enum;

namespace Api.Engines.Venda.Model
{
    public class MockQuestionario
    {
        private static void AdicionarSubPergunta(PerguntaQuestionario p3, PerguntaQuestionario sub, int idDominio)
        {
            var subPerguntas = p3.Dominio.FirstOrDefault(p => p.Id == idDominio).SubPerguntas;

            if (subPerguntas == null)
                subPerguntas = new List<PerguntaQuestionario>();

            subPerguntas.Add(sub);

            p3.Dominio.FirstOrDefault(p => p.Id == 1).SubPerguntas = subPerguntas;
        }

        private static PerguntaQuestionario CriarSubPergunta(PerguntaQuestionario p3, int id, int ordem, string descricao, TipoRespostaEnum tipoResposta, int idDominio)
        {
            var subPerguntas = p3.Dominio.FirstOrDefault(p => p.Id == idDominio).SubPerguntas;

            if (subPerguntas == null)
                subPerguntas = new List<PerguntaQuestionario>();

            var pergunta = new PerguntaQuestionario()
            {
                Id = id,
                Descricao = descricao,
                Tipo = new TipoItemQuestionario()
                {
                    Id = (int)TipoItemQuestionarioEnum.Pergunta,
                    Descricao = TipoItemQuestionarioEnum.Pergunta.GetDescription()
                },
                Ordem = ordem,
                TipoResposta = new TipoResposta()
                {
                    Id = (int)tipoResposta,
                    Descricao = tipoResposta.GetDescription()
                }
            };

            if (tipoResposta == TipoRespostaEnum.SimNao)
                pergunta.Dominio = new List<DominioResposta>()
                {
                    new DominioResposta()
                    {
                        Id = 1,
                        Descricao = "Sim"
                    },
                    new DominioResposta()
                    {
                        Id = 2,
                        Descricao = "Não",
                    }
                };

            subPerguntas.Add(pergunta);

            p3.Dominio.FirstOrDefault(p => p.Id == 1).SubPerguntas = subPerguntas;

            return pergunta;
        }

        private static List<int> TratarTarefasID(short dpsModelo, Dictionary<short, List<int>> listaTarefas, char sexo)
        {
            List<int> idDPS = new List<int> { dpsModelo };


            if (listaTarefas.ContainsKey(dpsModelo))
                idDPS = listaTarefas[dpsModelo];
            else
            {
                if (sexo == 'M')
                {
                    idDPS = new List<int> { valorBancoTransformadoM++ };
                }
                else
                if (sexo == 'F')
                {
                    idDPS = new List<int> { valorBancoTransformadoF++ };
                }
            }

            return idDPS;
        }

        private static string TratarTarefasDescricao(int dpsModelo, string descricao)
        {
            switch (dpsModelo)
            {
                case 187:
                case 1:
                    return "Informe peso (_kg):";
                case 188:
                case 2:
                    return "Informe altura (_m):";
                default:
                    return descricao;
            }
        }


        private static int valorBancoTransformadoM;
        private static int valorBancoTransformadoF;


        private static List<PerguntaQuestionario> TratarItemQuestionarioExistentes(List<ItemQuestionario> origem,
            List<ItemQuestionario> verificacao)
        {
            List<PerguntaQuestionario> retorno = new List<PerguntaQuestionario>();
            if (origem != null)
                foreach (var item in origem)
                {
                    if (verificacao.Exists(c => c.Id == item.Id))
                    {
                        retorno.Add((PerguntaQuestionario)item);
                    }
                }
            return retorno;
        }
        private static PerguntaQuestionario CriarItemQuestionarioSimples(ItemQuestionario origem, int ordem)
        {
            var retorno = CriarPerguntaQuestionario(origem.Id.Value, origem.Descricao, TipoRespostaEnum.Valor);
            retorno.Ordem = ordem;
            return retorno;
        }

        private static List<PerguntaQuestionario> TratarItemQuestionarioInexistentes(List<ItemQuestionario> origem,
        List<ItemQuestionario> verificacao, int ordem)
        {
            List<PerguntaQuestionario> retorno = new List<PerguntaQuestionario>();
            foreach (var item in verificacao)
            {
                if (origem != null)
                {
                    if (!origem.Exists(c => c.Id == item.Id))
                    {
                        retorno.Add(CriarItemQuestionarioSimples(item, ordem++));
                    }
                }
                else
                {
                    retorno.Add(CriarItemQuestionarioSimples(item, ordem++));
                }
            }
            return retorno;
        }

        private static List<ItemQuestionario> ConverterItem(List<ItemQuestionario> perguntaQuestionario)
        {
            List<ItemQuestionario> retorno = new List<ItemQuestionario>();
            foreach (var item in perguntaQuestionario)
            {
                retorno.Add((ItemQuestionario)item);
            }

            return retorno;
        }



        public static List<Questionario> TratarQuestionarios(List<Questionario> questionarioTratamento, List<PerguntasDps.Pergunta> pergunta, bool existeTipoConjuge)
        {
            List<Questionario> retorno = ClonarListaQuestionario(questionarioTratamento);

            List<ItemQuestionario> perguntasTratadasM = new List<ItemQuestionario>();
            List<ItemQuestionario> perguntasTratadasF = new List<ItemQuestionario>();

            Dictionary<short, List<int>> listaTarefas = RelacionamentosDps();

            valorBancoTransformadoM = 105;
            valorBancoTransformadoF = 105;
            foreach (var item in pergunta)
            {

                foreach (var itemDps in TratarTarefasID(item.Id, listaTarefas, item.Sexo))
                {
                    if (item.Sexo == 'M')
                    {
                        perguntasTratadasM.Add(new PerguntaQuestionario
                        {
                            Descricao = TratarTarefasDescricao(itemDps, item.Descricao),
                            Id = itemDps,
                            Ordem = item.OrdemApresentacao,
                            Tipo = new TipoItemQuestionario() { Id = 1, Descricao = "DPS" }
                        });
                    }
                    else
                    if (item.Sexo == 'F')
                    {
                        perguntasTratadasF.Add(new PerguntaQuestionario
                        {
                            Descricao = TratarTarefasDescricao(itemDps, item.Descricao),
                            Id = itemDps,
                            Ordem = item.OrdemApresentacao,
                            Tipo = new TipoItemQuestionario() { Id = 1, Descricao = "DPS" }
                        });
                    }
                }
            }


            foreach (var questionario in retorno)
            {
                int ordem = 10;

                if (!pergunta.Any())
                {
                    if ((questionario.Tipo.Id == 1))
                    {
                        questionario.Perguntas = null;
                    }
                    continue;
                }
                if ((questionario.Sexo.Id == 1) && (questionario.Tipo.Id == 1))
                {
                    var questionarioTratadoExistente = TratarItemQuestionarioExistentes(questionario.Perguntas, perguntasTratadasM);
                    if (questionario.Perguntas != null)
                        questionario.Perguntas.Clear();
                    else
                        questionario.Perguntas = new List<ItemQuestionario>();
                    questionario.Perguntas.AddRange(questionarioTratadoExistente);
                    var questionarioTratadoInexistente = TratarItemQuestionarioInexistentes(questionario.Perguntas, perguntasTratadasM, ordem);
                    questionario.Perguntas.AddRange(questionarioTratadoInexistente);
                }
                else
                if ((questionario.Sexo.Id == 2) && (questionario.Tipo.Id == 1))
                {
                    var questionarioTratadoExistente = TratarItemQuestionarioExistentes(questionario.Perguntas, perguntasTratadasF);
                    if (questionario.Perguntas != null)
                        questionario.Perguntas.Clear();
                    else
                        questionario.Perguntas = new List<ItemQuestionario>();
                    questionario.Perguntas.AddRange(questionarioTratadoExistente);
                    var questionarioTratadoInexistente = TratarItemQuestionarioInexistentes(questionario.Perguntas, perguntasTratadasF, ordem);
                    questionario.Perguntas.AddRange(questionarioTratadoInexistente);
                }
            }
            if (existeTipoConjuge)
            {
                retorno.AddRange(ClonarListaQuestionarioConjuge(retorno));
            }

            return retorno;
        }

        private static List<Questionario> ClonarListaQuestionarioConjuge(List<Questionario> questionarioTratamento)
        {
            List<Questionario> retorno = new List<Questionario>();
            foreach (var item in questionarioTratamento)
            {
                var perguntasClone = ConverterItem(item.Perguntas);
                retorno.Add(new Questionario()
                {
                    DataUltimaAlteracao = item.DataUltimaAlteracao,
                    Descricao = item.Descricao,
                    Id = item.Id,
                    RelacaoSegurado = new TipoRelacaoSegurado
                    {
                        Id = (int)TipoRelacaoSeguradoEnum.Conjuge,
                        Descricao = TipoRelacaoSeguradoEnum.Conjuge.GetDescription(),
                    },
                    Sexo = item.Sexo,
                    Tipo = item.Tipo,
                    Perguntas = perguntasClone
                });
            }
            return retorno;
        }

        private static List<Questionario> ClonarListaQuestionario(List<Questionario> questionarioTratamento)
        {
            List<Questionario> retorno = new List<Questionario>();
            foreach (var item in questionarioTratamento)
            {
                var perguntasClone = ConverterItem(item.Perguntas);
                retorno.Add(new Questionario()
                {
                    DataUltimaAlteracao = item.DataUltimaAlteracao,
                    Descricao = item.Descricao,
                    Id = item.Id,
                    RelacaoSegurado = item.RelacaoSegurado,
                    Sexo = item.Sexo,
                    Tipo = item.Tipo,
                    Perguntas = perguntasClone
                });
            }
            return retorno;
        }

        private static Dictionary<short, List<int>> RelacionamentosDps()
        {
            Dictionary<short, List<int>> listaTarefas =
           new Dictionary<short, List<int>>();


            listaTarefas.Add(1, new List<int>() { 3 });
            listaTarefas.Add(2, new List<int>() { 4 });
            listaTarefas.Add(3, new List<int>() { 10 });


            listaTarefas.Add(4, new List<int>() { 182 });

            listaTarefas.Add(5, new List<int>() { 6 });
            listaTarefas.Add(6, new List<int>() { 11 });
            listaTarefas.Add(7, new List<int>() { 12 });
            listaTarefas.Add(8, new List<int>() { 13 });
            listaTarefas.Add(9, new List<int>() { 7 });
            listaTarefas.Add(10, new List<int>() { 92 });
            listaTarefas.Add(11, new List<int>() { 1, 2 });
            listaTarefas.Add(12, new List<int>() { 91 });

            listaTarefas.Add(24, new List<int>() { 183 });


            listaTarefas.Add(25, new List<int>() { 4 });
            listaTarefas.Add(26, new List<int>() { 5 });
            listaTarefas.Add(27, new List<int>() { 89 });


            listaTarefas.Add(28, new List<int>() { 185 });
            listaTarefas.Add(29, new List<int>() { 186 });


            listaTarefas.Add(48, new List<int>() { 3 });
            listaTarefas.Add(49, new List<int>() { 193 });
            listaTarefas.Add(50, new List<int>() { 5 });
            listaTarefas.Add(51, new List<int>() { 89 });
            listaTarefas.Add(52, new List<int>() { 90 });
            listaTarefas.Add(53, new List<int>() { 8 });
            listaTarefas.Add(54, new List<int>() { 9 });
            listaTarefas.Add(55, new List<int>() { 187, 188 });
            return listaTarefas;
        }

        public static Dictionary<string, List<Questionario>> CriarQuestionarios()
        {
            var p1 = CriarPerguntaQuestionario(1, "Informe peso (_kg):", TipoRespostaEnum.Valor);
            var p2 = CriarPerguntaQuestionario(2, "Informe altura (_m):", TipoRespostaEnum.Valor);

            var p3 = CriarPerguntaQuestionarioSimNao(3, "Encontra-se com algum problema de saúde ou faz uso de algum medicamento atualmente?");
            CriarSubPergunta(p3, 14, 1, "Qual?", TipoRespostaEnum.TextoLivre, 1);

            var p4 = CriarPerguntaQuestionarioSimNao(4, "Sofre ou já sofreu de doenças do coração, insuficiência cardíaca, hipertensão arterial, problemas circulatórios ou cardiovasculares?");
            CriarSubPergunta(p4, 15, 1, "Informar quais e se já foi submetido a alguma cirurgia:", TipoRespostaEnum.TextoLivre, 1);


            var p193 = CriarPerguntaQuestionarioSimNao(193, "Sofre ou já sofreu de doenças do coração, hipertensão, circulatórias, do sangue, diabetes, pulmão, fígado, rins, infarto, acidente vascular cerebral, articulações, qualquer tipo de câncer ou HIV?");
            CriarSubPergunta(p193, 192, 1, "Informar quais e se já foi submetido a alguma cirurgia:", TipoRespostaEnum.TextoLivre, 1);





            var p5 = CriarPerguntaQuestionarioSimNao(5, "Sofre ou sofreu de deficiências de órgãos, membros ou sentidos, incluindo doenças ortopédicas relacionadas a esforço repetitivo (LER e DORT)?");
            CriarSubPergunta(p5, 16, 1, "Informar quais:", TipoRespostaEnum.TextoLivre, 1);

            var p6 = CriarPerguntaQuestionarioSimNao(6, "Foi submetido a alguma intervenção cirúrgica, inclusive biópsia ou punção, ou esteve internado(a) em regime hospitalar para tratamento médico nos últimos 5 (cinco) anos?");
            CriarSubPergunta(p6, 17, 1, "Especificar:", TipoRespostaEnum.TextoLivre, 1);

            var p7 = CriarPerguntaQuestionarioSimNao(7, "Encontra-se afastado(a) da atividade de trabalho por motivo de doença ou aposentadoria por invalidez?");
            var p8 = CriarPerguntaQuestionarioSimNao(8, "Pratica paraquedismo, motociclismo, boxe, asa delta, rodeio, alpinismo, voo livre, automobilismo, mergulho ou exerce atividade, em caráter profissional ou amador, a bordo de aeronaves, que não sejam de linhas regulares?");
            var p181 = CriarSubPergunta(p8, 18, 1, "Quais atividades?", TipoRespostaEnum.Dominio, 1);

            var p201 = CriarPerguntaQuestionario(201, "Frequência:", TipoRespostaEnum.Dominio);
            p201.Ordem = 1;
            p201.TipoVariacaoResposta = new TipoVariacaoResposta()
            {
                Id = (int)TipoVariacaoRespostaEnum.SelecaoUnica,
                Descricao = TipoVariacaoRespostaEnum.SelecaoUnica.GetDescription()
            };
            p201.Dominio = new List<DominioResposta>()
            {
                new DominioResposta() { Id = 1, Descricao = "Um dia na semana" },
                new DominioResposta() { Id = 2, Descricao = "Dois dias na semana" },
                new DominioResposta() { Id = 3, Descricao = "Três dias na semana" },
                new DominioResposta() { Id = 4, Descricao = "Quatro dias na semana" },
                new DominioResposta() { Id = 5, Descricao = "Cinco dias na semana" },
                new DominioResposta() { Id = 6, Descricao = "Seis dias na semana" },
                new DominioResposta() { Id = 7, Descricao = "Todos os dias na semana" },
            };

            var p202 = CriarPerguntaQuestionario(202, "Tipo de Ambiente:", TipoRespostaEnum.Dominio);
            p202.Ordem = 2;
            p202.TipoVariacaoResposta = new TipoVariacaoResposta()
            {
                Id = (int)TipoVariacaoRespostaEnum.SelecaoUnica,
                Descricao = TipoVariacaoRespostaEnum.SelecaoUnica.GetDescription()
            };
            p202.Dominio = new List<DominioResposta>()
            {
                new DominioResposta() { Id = 1, Descricao = "Fechado" },
                new DominioResposta() { Id = 2, Descricao = "Aberto" }
            };

            var p203 = CriarPerguntaQuestionario(203, "Caráter da atividade:", TipoRespostaEnum.Dominio);
            p203.Ordem = 3;
            p203.TipoVariacaoResposta = new TipoVariacaoResposta()
            {
                Id = (int)TipoVariacaoRespostaEnum.SelecaoUnica,
                Descricao = TipoVariacaoRespostaEnum.SelecaoUnica.GetDescription()
            };
            p203.Dominio = new List<DominioResposta>()
            {
                new DominioResposta() { Id = 1, Descricao = "Hobby" },
                new DominioResposta() { Id = 2, Descricao = "Com acompanhamento profissional" }
            };

            var p204 = CriarPerguntaQuestionario(204, "Qual atividade?", TipoRespostaEnum.TextoLivre);
            p204.Ordem = 4;

            p181.Ordem = 1;
            p181.TipoVariacaoResposta = new TipoVariacaoResposta()
            {
                Id = (int)TipoVariacaoRespostaEnum.MultiSelecao,
                Descricao = TipoVariacaoRespostaEnum.MultiSelecao.GetDescription()
            };
            p181.Dominio = new List<DominioResposta>()
            {
                new DominioResposta() { Id = 1, Descricao = "Paraquedismo", SubPerguntas = new List<PerguntaQuestionario>() { p201, p202, p203 } },
                new DominioResposta() { Id = 2, Descricao = "Motociclismo", SubPerguntas = new List<PerguntaQuestionario>() { p201, p202, p203 } },
                new DominioResposta() { Id = 3, Descricao = "Boxe", SubPerguntas = new List<PerguntaQuestionario>() { p201, p202, p203 } },
                new DominioResposta() { Id = 4, Descricao = "Asa delta", SubPerguntas = new List<PerguntaQuestionario>() { p201, p202, p203 } },
                new DominioResposta() { Id = 5, Descricao = "Rodeio", SubPerguntas = new List<PerguntaQuestionario>() { p201, p202, p203 } },
                new DominioResposta() { Id = 6, Descricao = "Alpinismo", SubPerguntas = new List<PerguntaQuestionario>() { p201, p202, p203 } },
                new DominioResposta() { Id = 7, Descricao = "Voo livre", SubPerguntas = new List<PerguntaQuestionario>() { p201, p202, p203 } },
                new DominioResposta() { Id = 8, Descricao = "Automobilismo", SubPerguntas = new List<PerguntaQuestionario>() { p201, p202, p203 } },
                new DominioResposta() { Id = 9, Descricao = "Mergulho", SubPerguntas = new List<PerguntaQuestionario>() { p201, p202, p203 } },
                new DominioResposta() { Id = 10, Descricao = "Atividade, em caráter profissional ou amador, a bordo de aeronaves, que não sejam de linhas regulares", SubPerguntas = new List<PerguntaQuestionario>() { p201, p202, p203, p204 } }
            };

            var p9 = CriarPerguntaQuestionarioSimNao(9, "É fumante?");
            CriarSubPergunta(p9, 19, 1, "Informar a quantidade média de cigarros por dia:", TipoRespostaEnum.Valor, 1);

            var p10 = CriarPerguntaQuestionarioSimNao(10, "Sofre de doenças do sangue ou de diabetes, doenças do pulmão, enfisema, doenças do fígado, doenças do aparelho digestivo ou doenças renais?");
            CriarSubPergunta(p10, 20, 1, "Informar quais:", TipoRespostaEnum.TextoLivre, 1);

            var p11 = CriarPerguntaQuestionarioSimNao(11, "Sofre ou já sofreu de tumores ou câncer ou já foi submetido(a) a tratamento com radioterapia, quimioterapia ou outros tratamentos auxiliares?");
            CriarSubPergunta(p11, 21, 1, "Especificar:", TipoRespostaEnum.TextoLivre, 1);

            var p12 = CriarPerguntaQuestionarioSimNao(12, "Sofre ou já sofreu de algum tipo de hérnia ou doenças ortopédicas relacionadas a esforço repetitivo?");
            CriarSubPergunta(p12, 22, 1, "Especificar:", TipoRespostaEnum.TextoLivre, 1);

            var p13 = CriarPerguntaQuestionarioSimNao(13, "É portador(a) do vírus HIV?");

            Dictionary<string, List<Questionario>> questionarios = new Dictionary<string, List<Questionario>>();

            p1.Ordem = 8;
            p2.Ordem = 9;
            p3.Ordem = 1;
            p4.Ordem = 2;
            p5.Ordem = 3;
            p6.Ordem = 4;
            p7.Ordem = 5;
            p8.Ordem = 6;
            p9.Ordem = 7;

            #region FA

            var questionarioFA_F = new Questionario()
            {
                Id = 1,
                Descricao = "Declaração Pessoal de Saúde",
                DataUltimaAlteracao = DateTime.Now, /*alterar*/
                Tipo = new TipoQuestionario
                {
                    Id = (int)TipoQuestionarioEnum.DPS,
                    Descricao = TipoQuestionarioEnum.DPS.GetDescription()
                },
                Sexo = new Sexo()
                {
                    Id = (int)SexoEnum.Feminino,
                    Descricao = SexoEnum.Feminino.GetDescription()
                },
                RelacaoSegurado = new TipoRelacaoSegurado
                {
                    Id = (int)TipoRelacaoSeguradoEnum.Titular,
                    Descricao = TipoRelacaoSeguradoEnum.Titular.GetDescription(),
                },
                Perguntas = new List<ItemQuestionario>() {
                    p1.DeepClone(), p2.DeepClone(), p3.DeepClone(), p4.DeepClone(), p5.DeepClone(), p6.DeepClone(), p7.DeepClone(), p8.DeepClone(), p9.DeepClone()
                }
            };

            var questionarioFA_M = new Questionario()
            {
                Id = 2,
                Descricao = "Declaração Pessoal de Saúde",
                DataUltimaAlteracao = DateTime.Now, /*alterar*/
                Tipo = new TipoQuestionario
                {
                    Id = (int)TipoQuestionarioEnum.DPS,
                    Descricao = TipoQuestionarioEnum.DPS.GetDescription()
                },
                Sexo = new Sexo()
                {
                    Id = (int)SexoEnum.Masculino,
                    Descricao = SexoEnum.Masculino.GetDescription()
                },
                RelacaoSegurado = new TipoRelacaoSegurado
                {
                    Id = (int)TipoRelacaoSeguradoEnum.Titular,
                    Descricao = TipoRelacaoSeguradoEnum.Titular.GetDescription(),
                },
                Perguntas = new List<ItemQuestionario>() {
                    p1.DeepClone(), p2.DeepClone(), p3.DeepClone(), p4.DeepClone(), p5.DeepClone(), p6.DeepClone(), p7.DeepClone(), p8.DeepClone(), p9.DeepClone()
                }
            };

            #endregion FA



            #region FN

            var questionarioFN_F = new Questionario()
            {
                Id = 5,
                Descricao = "Declaração Pessoal de Saúde",
                DataUltimaAlteracao = DateTime.Now, /*alterar*/
                Tipo = new TipoQuestionario
                {
                    Id = (int)TipoQuestionarioEnum.DPS,
                    Descricao = TipoQuestionarioEnum.DPS.GetDescription()
                },
                Sexo = new Sexo()
                {
                    Id = (int)SexoEnum.Feminino,
                    Descricao = SexoEnum.Feminino.GetDescription()
                },
                RelacaoSegurado = new TipoRelacaoSegurado
                {
                    Id = (int)TipoRelacaoSeguradoEnum.Titular,
                    Descricao = TipoRelacaoSeguradoEnum.Titular.GetDescription(),
                },
                Perguntas = new List<ItemQuestionario>() {
                    p1.DeepClone(), p2.DeepClone(), p3.DeepClone(), p4.DeepClone(), p5.DeepClone(), p6.DeepClone(), p7.DeepClone(), p8.DeepClone(), p9.DeepClone()
                }
            };

            var questionarioFN_M = new Questionario()
            {
                Id = 6,
                Descricao = "Declaração Pessoal de Saúde",
                DataUltimaAlteracao = DateTime.Now, /*alterar*/
                Tipo = new TipoQuestionario
                {
                    Id = (int)TipoQuestionarioEnum.DPS,
                    Descricao = TipoQuestionarioEnum.DPS.GetDescription()
                },
                Sexo = new Sexo()
                {
                    Id = (int)SexoEnum.Masculino,
                    Descricao = SexoEnum.Masculino.GetDescription()
                },
                RelacaoSegurado = new TipoRelacaoSegurado
                {
                    Id = (int)TipoRelacaoSeguradoEnum.Titular,
                    Descricao = TipoRelacaoSeguradoEnum.Titular.GetDescription(),
                },
                Perguntas = new List<ItemQuestionario>() {
                    p1.DeepClone(), p2.DeepClone(), p3.DeepClone(), p4.DeepClone(), p5.DeepClone(), p6.DeepClone(), p7.DeepClone(), p8.DeepClone(), p9.DeepClone()
                }
            };

            #endregion FN

            #region MB

            var p3_1 = CriarPerguntaQuestionarioValor(p3);
            CriarSubPergunta(p3_1, 14, 1, "Qual?", TipoRespostaEnum.TextoLivre, 1);

            var p4_1 = CriarPerguntaQuestionarioValor(p4);
            CriarSubPergunta(p4_1, 15, 1, "Informar quais e se já foi submetido a alguma cirurgia.", TipoRespostaEnum.TextoLivre, 1);

            var p5_1 = CriarPerguntaQuestionarioValor(p5);
            CriarSubPergunta(p5_1, 16, 1, "Informar quais.", TipoRespostaEnum.TextoLivre, 1);

            var p6_1 = CriarPerguntaQuestionarioValor(p6);
            CriarSubPergunta(p6_1, 17, 1, "Especificar.", TipoRespostaEnum.TextoLivre, 1);

            var p7_1 = CriarPerguntaQuestionarioValor(p7);
            var p8_1 = CriarPerguntaQuestionarioValor(p8);
            CriarSubPergunta(p8_1, 18, 1, "Especificar.", TipoRespostaEnum.TextoLivre, 1);

            var p9_1 = CriarPerguntaQuestionarioValor(p9);
            CriarSubPergunta(p9_1, 19, 1, "Informar a quantidade média de cigarros por dia.", TipoRespostaEnum.Valor, 1);

            p3_1.Ordem = 1;
            p4_1.Ordem = 2;
            p5_1.Ordem = 3;
            p6_1.Ordem = 4;
            p7_1.Ordem = 5;
            p8_1.Ordem = 6;
            p9_1.Ordem = 7;
            p10.Ordem = 8;
            p11.Ordem = 9;
            p12.Ordem = 10;
            p13.Ordem = 11;

            var questionarioMB_F = new Questionario()
            {
                Id = 3,
                Descricao = "Declaração Pessoal de Saúde",
                DataUltimaAlteracao = DateTime.Now, /*alterar*/
                Tipo = new TipoQuestionario
                {
                    Id = (int)TipoQuestionarioEnum.DPS,
                    Descricao = TipoQuestionarioEnum.DPS.GetDescription()
                },
                Sexo = new Sexo()
                {
                    Id = (int)SexoEnum.Feminino,
                    Descricao = SexoEnum.Feminino.GetDescription()
                },
                RelacaoSegurado = new TipoRelacaoSegurado
                {
                    Id = (int)TipoRelacaoSeguradoEnum.Titular,
                    Descricao = TipoRelacaoSeguradoEnum.Titular.GetDescription(),
                },
                Perguntas = new List<ItemQuestionario>() {
                    p3_1, p4_1, p5_1, p6_1, p7_1, p8_1, p9_1, p10, p11, p12, p13
                }
            };

            var questionarioMB_M = new Questionario()
            {
                Id = 4,
                Descricao = "Declaração Pessoal de Saúde",
                DataUltimaAlteracao = DateTime.Now, /*alterar*/
                Tipo = new TipoQuestionario
                {
                    Id = (int)TipoQuestionarioEnum.DPS,
                    Descricao = TipoQuestionarioEnum.DPS.GetDescription()
                },
                Sexo = new Sexo()
                {
                    Id = (int)SexoEnum.Masculino,
                    Descricao = SexoEnum.Masculino.GetDescription()
                },
                RelacaoSegurado = new TipoRelacaoSegurado
                {
                    Id = (int)TipoRelacaoSeguradoEnum.Titular,
                    Descricao = TipoRelacaoSeguradoEnum.Titular.GetDescription(),
                },
                Perguntas = new List<ItemQuestionario>() {
                    p3_1, p4_1, p5_1, p6_1, p7_1, p8_1, p9_1, p10, p11, p12, p13
                }
            };

            #endregion MB

            #region GS

            var questionarioGS_F = new Questionario()
            {
                Id = 7,
                Descricao = "Declaração Pessoal de Saúde",
                DataUltimaAlteracao = DateTime.Now, /*alterar*/
                Tipo = new TipoQuestionario
                {
                    Id = (int)TipoQuestionarioEnum.DPS,
                    Descricao = TipoQuestionarioEnum.DPS.GetDescription()
                },
                Sexo = new Sexo()
                {
                    Id = (int)SexoEnum.Feminino,
                    Descricao = SexoEnum.Feminino.GetDescription()
                },
                RelacaoSegurado = new TipoRelacaoSegurado
                {
                    Id = (int)TipoRelacaoSeguradoEnum.Titular,
                    Descricao = TipoRelacaoSeguradoEnum.Titular.GetDescription(),
                },
                Perguntas = new List<ItemQuestionario>() {
                    p1.DeepClone(), p2.DeepClone(), p3.DeepClone(), p4.DeepClone(), p5.DeepClone(), p6.DeepClone(), p7.DeepClone(), p8.DeepClone(), p9.DeepClone()
                }
            };

            var questionarioGS_M = new Questionario()
            {
                Id = 8,
                Descricao = "Declaração Pessoal de Saúde",
                DataUltimaAlteracao = DateTime.Now, /*alterar*/
                Tipo = new TipoQuestionario
                {
                    Id = (int)TipoQuestionarioEnum.DPS,
                    Descricao = TipoQuestionarioEnum.DPS.GetDescription()
                },
                Sexo = new Sexo()
                {
                    Id = (int)SexoEnum.Masculino,
                    Descricao = SexoEnum.Masculino.GetDescription()
                },
                RelacaoSegurado = new TipoRelacaoSegurado
                {
                    Id = (int)TipoRelacaoSeguradoEnum.Titular,
                    Descricao = TipoRelacaoSeguradoEnum.Titular.GetDescription(),
                },
                Perguntas = new List<ItemQuestionario>() {
                    p1.DeepClone(), p2.DeepClone(), p3.DeepClone(), p4.DeepClone(), p5.DeepClone(), p6.DeepClone(), p7.DeepClone(), p8.DeepClone(), p9.DeepClone()
                }
            };

            #endregion GS

            #region XP

            var p79 = CriarAgrupadorQuestionario(79, "RENDA ANUAL");
            var p14 = CriarPerguntaQuestionario(14, "Por trabalho:", TipoRespostaEnum.Valor);
            var p15 = CriarPerguntaQuestionario(15, "Eventuais:", TipoRespostaEnum.Valor);
            p14.Ordem = 1;
            p15.Ordem = 2;
            p79.Perguntas = new List<ItemQuestionario>();
            p79.Perguntas.Add(p14);
            p79.Perguntas.Add(p15);

            var p80 = CriarAgrupadorQuestionario(80, "PATRIMÔNIO");
            var p16 = CriarPerguntaQuestionarioSimNao(16, "Possui imóveis?");
            var p36 = CriarSubPergunta(p16, 36, 1, "Quantidade:", TipoRespostaEnum.Valor, 1);
            var p37 = CriarSubPergunta(p16, 37, 2, "Valor:", TipoRespostaEnum.Valor, 1);

            var p17 = CriarPerguntaQuestionarioSimNao(17, "Possui veículos?");
            var p38 = CriarSubPergunta(p17, 38, 1, "Quantidade:", TipoRespostaEnum.Valor, 1);
            var p39 = CriarSubPergunta(p17, 39, 2, "Valor:", TipoRespostaEnum.Valor, 1);

            var p18 = CriarPerguntaQuestionarioSimNao(18, "Possui aplicações financeiras?");
            var p40 = CriarSubPergunta(p18, 40, 1, "Quantidade:", TipoRespostaEnum.Valor, 1);
            var p41 = CriarSubPergunta(p18, 41, 2, "Valor:", TipoRespostaEnum.Valor, 1);

            var p19 = CriarPerguntaQuestionarioSimNao(19, "Possui outros ativos?");
            var p42 = CriarSubPergunta(p19, 42, 1, "Quantidade:", TipoRespostaEnum.Valor, 1);
            var p43 = CriarSubPergunta(p19, 43, 2, "Valor:", TipoRespostaEnum.Valor, 1);

            p16.Ordem = 1;
            p17.Ordem = 2;
            p18.Ordem = 3;
            p19.Ordem = 4;

            p80.Perguntas = new List<ItemQuestionario>();
            p80.Perguntas.Add(p16);
            p80.Perguntas.Add(p17);
            p80.Perguntas.Add(p18);
            p80.Perguntas.Add(p19);

            var p81 = CriarAgrupadorQuestionario(81, "DÍVIDAS");
            var p20 = CriarPerguntaQuestionario(20, "Valor a vencer:", TipoRespostaEnum.Valor);
            var p21 = CriarPerguntaQuestionario(21, "Valor vencido e pendente:", TipoRespostaEnum.Valor);

            p20.Ordem = 1;
            p21.Ordem = 2;

            p81.Perguntas = new List<ItemQuestionario>();
            p81.Perguntas.Add(p20);
            p81.Perguntas.Add(p21);

            var p82 = CriarAgrupadorQuestionario(82, "SEGUROS");
            var p22 = CriarPerguntaQuestionarioSimNao(22, "Alguma seguradora já recusou segurar, renovar ou reintegrar, agravou, modificou ou cancelou seguro de vida em seu nome?");
            var p44 = CriarSubPergunta(p22, 44, 1, "Data:", TipoRespostaEnum.Valor, 1);
            var p45 = CriarSubPergunta(p22, 45, 2, "Motivo alegado:", TipoRespostaEnum.TextoLivre, 1);

            var p23 = CriarPerguntaQuestionarioSimNao(23, "Você possui outra apólice de seguros em vigor ou em análise?");
            var p46 = CriarSubPergunta(p23, 46, 1, "Possui cobertura de Morte?", TipoRespostaEnum.SimNao, 1);
            var p71 = CriarSubPergunta(p46, 71, 1, "Capital:", TipoRespostaEnum.Valor, 1);
            var p72 = CriarSubPergunta(p46, 72, 2, "Data de Contratação:", TipoRespostaEnum.Valor, 1);

            var p47 = CriarSubPergunta(p23, 47, 2, "Possui cobertura de Morte Acidental?", TipoRespostaEnum.SimNao, 1);
            var p73 = CriarSubPergunta(p47, 73, 1, "Capital:", TipoRespostaEnum.Valor, 1);
            var p74 = CriarSubPergunta(p47, 74, 2, "Data de Contratação:", TipoRespostaEnum.Valor, 1);

            var p48 = CriarSubPergunta(p23, 48, 3, "Possui cobertura de Doenças Graves?", TipoRespostaEnum.SimNao, 1);
            var p75 = CriarSubPergunta(p48, 75, 1, "Capital:", TipoRespostaEnum.Valor, 1);
            var p76 = CriarSubPergunta(p48, 76, 2, "Data de Contratação:", TipoRespostaEnum.Valor, 1);

            var p49 = CriarSubPergunta(p23, 49, 4, "Possui cobertura de Invalidez por Acidente e/ou Doença?", TipoRespostaEnum.SimNao, 1);
            var p77 = CriarSubPergunta(p49, 77, 1, "Capital:", TipoRespostaEnum.Valor, 1);
            var p78 = CriarSubPergunta(p49, 78, 2, "Data de Contratação:", TipoRespostaEnum.Valor, 1);

            var p50 = CriarSubPergunta(p23, 50, 5, "Caso esta proposta seja aceita, você pretende cancelar ou alterar o seguro em vigor?", TipoRespostaEnum.SimNao, 1);

            p22.Ordem = 1;
            p23.Ordem = 2;

            p82.Perguntas = new List<ItemQuestionario>();
            p82.Perguntas.Add(p22);
            p82.Perguntas.Add(p23);

            var p83 = CriarAgrupadorQuestionario(83, "HISTÓRICO DE VIAGENS");
            var p24 = CriarPerguntaQuestionarioSimNao(24, "Costuma viajar em aeronaves pequenas (táxis aéreos, aeronaves particulares, helicópteros etc)?");
            var p51 = CriarSubPergunta(p24, 51, 1, "Frequência anual:", TipoRespostaEnum.Valor, 1);
            var p52 = CriarSubPergunta(p24, 52, 2, "Tipo de Aeronave:", TipoRespostaEnum.TextoLivre, 1);
            var p53 = CriarSubPergunta(p24, 53, 3, "Principais Destinos:", TipoRespostaEnum.TextoLivre, 1);

            var p25 = CriarPerguntaQuestionarioSimNao(25, "Você tem a intenção de viajar para fora do país, a turismo ou negócio, nos próximos 2 (dois) anos?");
            var p54 = CriarSubPergunta(p25, 54, 1, "Destinos:", TipoRespostaEnum.TextoLivre, 1);
            var p55 = CriarSubPergunta(p25, 55, 2, "Objetivo:", TipoRespostaEnum.TextoLivre, 1);
            var p56 = CriarSubPergunta(p25, 56, 3, "Número de viagens previstas por ano:", TipoRespostaEnum.Valor, 1);
            var p57 = CriarSubPergunta(p25, 57, 4, "Tempo de estada:", TipoRespostaEnum.Valor, 1);

            var p26 = CriarPerguntaQuestionarioSimNao(26, "Você pilotou nos últimos 2 (dois) anos, ou pretende pilotar, algum tipo de aeronave?");

            p24.Ordem = 1;
            p25.Ordem = 2;
            p26.Ordem = 3;

            p83.Perguntas = new List<ItemQuestionario>();
            p83.Perguntas.Add(p24);
            p83.Perguntas.Add(p25);
            p83.Perguntas.Add(p26);

            // ATIVIDADES DE ESPORTE E LAZER
            var p84 = CriarAgrupadorQuestionario(84, "ATIVIDADES DE ESPORTE E LAZER");
            var p27 = CriarPerguntaQuestionarioSimNao(27, "Você participou nos últimos 2 (dois) anos, ou pretende participar, de competições ou atividades de esporte e lazer que incluam modalidades aeronáuticas (incluindo, mas não se limitando, a: paraglide, ultraleve, planador, balonismo, parapente, asa-delta)?");
            var p58 = CriarSubPergunta(p27, 58, 1, "Especifique:", TipoRespostaEnum.TextoLivre, 1);

            var p28 = CriarPerguntaQuestionarioSimNao(28, "Você participou nos últimos 2 (dois) anos, ou pretende participar, de competições ou atividades de esporte e lazer que incluam atividades em carros de propulsão a jato ou veículos de competição (incluindo, mas não se limitando, a: motocicletas, carros e barcos de corrida)?");
            var p59 = CriarSubPergunta(p28, 59, 1, "Especifique:", TipoRespostaEnum.TextoLivre, 1);

            var p29 = CriarPerguntaQuestionarioSimNao(29, "Você participou nos últimos 2 (dois) anos, ou pretende participar, de competições ou atividades de esporte e lazer que incluam atividades em carros sobre trilhas, areia, neve ou gelo (incluindo, mas não se limitando, a: snowmobiles, bicicletas de montanhismo, buggies para dunas)?");
            var p60 = CriarSubPergunta(p29, 60, 1, "Especifique:", TipoRespostaEnum.TextoLivre, 1);

            var p30 = CriarPerguntaQuestionarioSimNao(30, "Você participou nos últimos 2 (dois) anos, ou pretende participar, de competições ou atividades de esporte e lazer que incluam atividades de mergulho, montanhismo, rodeio ou competições de esqui na neve?");
            var p61 = CriarSubPergunta(p30, 61, 1, "Especifique:", TipoRespostaEnum.TextoLivre, 1);

            var p31 = CriarPerguntaQuestionarioSimNao(31, "Você participou nos últimos 2 (dois) anos, ou pretende participar, de competições ou atividades de esporte e lazer que incluam outras atividades de esporte e lazer que não as elencadas acima?");
            var p62 = CriarSubPergunta(p31, 62, 1, "Especifique:", TipoRespostaEnum.TextoLivre, 1);

            p27.Ordem = 1;
            p28.Ordem = 2;
            p29.Ordem = 3;
            p30.Ordem = 4;
            p31.Ordem = 5;

            p84.Perguntas = new List<ItemQuestionario>();
            p84.Perguntas.Add(p27);
            p84.Perguntas.Add(p28);
            p84.Perguntas.Add(p29);
            p84.Perguntas.Add(p30);
            p84.Perguntas.Add(p31);

            // TABAGISMO, CONSUMO DE ÁLCOOL E DROGAS
            var p85 = CriarAgrupadorQuestionario(85, "TABAGISMO, CONSUMO DE ÁLCOOL E DROGAS");
            var p32 = CriarPerguntaQuestionarioSimNao(32, "Você utiliza, ou já utilizou, produtos com tabaco em sua composição?");
            var p63 = CriarSubPergunta(p32, 63, 1, "Cigarro - Quantidade diária:", TipoRespostaEnum.Valor, 1);
            var p64 = CriarSubPergunta(p32, 64, 2, "Charuto - Quantidade mensal:", TipoRespostaEnum.Valor, 1);
            var p65 = CriarSubPergunta(p32, 65, 3, "Outros, especifique:", TipoRespostaEnum.TextoLivre, 1);
            var p66 = CriarSubPergunta(p32, 66, 4, "Outros - Quantidade mensal:", TipoRespostaEnum.Valor, 1);
            var p67 = CriarSubPergunta(p32, 67, 5, "Somente para ex-usuários – Ano em que fez a última utilização:", TipoRespostaEnum.Valor, 1);

            var p33 = CriarPerguntaQuestionarioSimNao(33, "Você consome bebida alcóolica?");
            var p68 = CriarSubPergunta(p33, 68, 1, "Indique a quantidade consumida semanalmente (copos) de Vinho", TipoRespostaEnum.Valor, 1);
            var p69 = CriarSubPergunta(p33, 69, 2, "Indique a quantidade consumida semanalmente (copos) de Cerveja", TipoRespostaEnum.Valor, 1);
            var p70 = CriarSubPergunta(p33, 70, 3, "Outros, especifique:", TipoRespostaEnum.TextoLivre, 1);

            var p34 = CriarPerguntaQuestionarioSimNao(34, "Já consultou médico ou fez tratamento em decorrência do consumo de álcool?");
            var p35 = CriarPerguntaQuestionarioSimNao(35, "Já fez uso de substâncias derivadas de maconha, cocaína ou outras drogas?");

            p32.Ordem = 1;
            p33.Ordem = 2;
            p34.Ordem = 3;
            p35.Ordem = 4;

            p85.Perguntas = new List<ItemQuestionario>();
            p85.Perguntas.Add(p32);
            p85.Perguntas.Add(p33);
            p85.Perguntas.Add(p34);
            p85.Perguntas.Add(p35);

            p79.Ordem = 1;
            p80.Ordem = 2;
            p81.Ordem = 3;
            p82.Ordem = 4;
            p83.Ordem = 5;
            p84.Ordem = 6;
            p85.Ordem = 7;

            var questionarioHP_XP_F = new Questionario()
            {
                Id = 9,
                Descricao = "Histórico Pessoal",
                DataUltimaAlteracao = DateTime.Now, /*alterar*/
                Tipo = new TipoQuestionario
                {
                    Id = (int)TipoQuestionarioEnum.HistoricoPessoal,
                    Descricao = TipoQuestionarioEnum.HistoricoPessoal.GetDescription()
                },
                Sexo = new Sexo()
                {
                    Id = (int)SexoEnum.Feminino,
                    Descricao = SexoEnum.Feminino.GetDescription()
                },
                RelacaoSegurado = new TipoRelacaoSegurado
                {
                    Id = (int)TipoRelacaoSeguradoEnum.Titular,
                    Descricao = TipoRelacaoSeguradoEnum.Titular.GetDescription(),
                },
                Perguntas = new List<ItemQuestionario>() {
                    p79, p80, p81, p82, p83, p84, p85
                }
            };

            var questionarioHP_XP_M = new Questionario()
            {
                Id = 10,
                Descricao = "Histórico Pessoal",
                DataUltimaAlteracao = DateTime.Now, /*alterar*/
                Tipo = new TipoQuestionario
                {
                    Id = (int)TipoQuestionarioEnum.HistoricoPessoal,
                    Descricao = TipoQuestionarioEnum.HistoricoPessoal.GetDescription()
                },
                Sexo = new Sexo()
                {
                    Id = (int)SexoEnum.Masculino,
                    Descricao = SexoEnum.Masculino.GetDescription()
                },
                RelacaoSegurado = new TipoRelacaoSegurado
                {
                    Id = (int)TipoRelacaoSeguradoEnum.Titular,
                    Descricao = TipoRelacaoSeguradoEnum.Titular.GetDescription(),
                },
                Perguntas = new List<ItemQuestionario>() {
                    p79, p80, p81, p82, p83, p84, p85
                }
            };

            var p86 = CriarPerguntaQuestionarioSimNao(86, "Encontra-se com algum problema de saúde ou faz uso de algum medicamento?");
            var p93 = CriarSubPergunta(p86, 93, 1, "Especifique:", TipoRespostaEnum.TextoLivre, 1);

            var p87 = CriarPerguntaQuestionarioSimNao(87, "Sofre ou já sofreu de doenças do coração, hipertensão, circulatórias, do sangue, diabetes, pulmão, fígado, rins, infarto, acidente vascular cerebral, articulações, qualquer tipo de câncer ou HIV?");
            var p94 = CriarSubPergunta(p87, 94, 1, "Especifique:", TipoRespostaEnum.TextoLivre, 1);

            var p88 = CriarPerguntaQuestionarioSimNao(88, "Sofre ou sofreu de deficiências de órgãos, membros ou sentidos, incluindo doenças ortopédicas relacionadas a esforço repetitivo (LER e DORT)?");
            var p95 = CriarSubPergunta(p88, 95, 1, "Especifique:", TipoRespostaEnum.TextoLivre, 1);

            var p89 = CriarPerguntaQuestionarioSimNao(89, "Fez alguma cirurgia, biópsia ou esteve internado nos últimos cinco anos?");
            var p96 = CriarSubPergunta(p89, 96, 1, "Especifique:", TipoRespostaEnum.TextoLivre, 1);

            var p90 = CriarPerguntaQuestionarioSimNao(90, "Está afastado(a) do trabalho ou aposentado(a) por invalidez?");
            var p97 = CriarSubPergunta(p90, 97, 1, "Especifique:", TipoRespostaEnum.TextoLivre, 1);

            var p91 = CriarPerguntaQuestionarioSimNao(91, "Pratica paraquedismo, motociclismo, boxe, asa-delta, rodeio, alpinismo, voo livre, automobilismo, mergulho ou exerce atividade, em caráter profissional ou amador, a bordo de aeronaves, que não seja de linhas regulares?");
            var p98 = CriarSubPergunta(p91, 98, 1, "Especifique:", TipoRespostaEnum.TextoLivre, 1);

            var p92 = CriarPerguntaQuestionarioSimNao(92, "É fumante?");
            var p99 = CriarSubPergunta(p92, 99, 1, "Cigarro?", TipoRespostaEnum.SimNao, 1);
            var p101 = CriarSubPergunta(p99, 101, 1, "Quantidade média/dia:", TipoRespostaEnum.Valor, 1);
            var p100 = CriarSubPergunta(p92, 100, 1, "Outros?", TipoRespostaEnum.SimNao, 1);
            var p102 = CriarSubPergunta(p100, 102, 1, "Quantidade média/dia:", TipoRespostaEnum.Valor, 1);

            var p103 = CriarPerguntaQuestionario(103, "Informe peso (_kg):", TipoRespostaEnum.Valor);
            var p104 = CriarPerguntaQuestionario(104, "Informe altura (_m):", TipoRespostaEnum.Valor);

            p86.Ordem = 1;
            p87.Ordem = 2;
            p88.Ordem = 3;
            p89.Ordem = 4;
            p90.Ordem = 5;
            p91.Ordem = 6;
            p92.Ordem = 7;
            p103.Ordem = 8;
            p104.Ordem = 9;

            var questionarioDPS_XP_F = new Questionario()
            {
                Id = 11,
                Descricao = "Declaração Pessoal de Saúde",
                DataUltimaAlteracao = DateTime.Now, /*alterar*/
                Tipo = new TipoQuestionario
                {
                    Id = (int)TipoQuestionarioEnum.DPS,
                    Descricao = TipoQuestionarioEnum.DPS.GetDescription()
                },
                Sexo = new Sexo()
                {
                    Id = (int)SexoEnum.Feminino,
                    Descricao = SexoEnum.Feminino.GetDescription()
                },
                RelacaoSegurado = new TipoRelacaoSegurado
                {
                    Id = (int)TipoRelacaoSeguradoEnum.Titular,
                    Descricao = TipoRelacaoSeguradoEnum.Titular.GetDescription(),
                },
                Perguntas = new List<ItemQuestionario>() {
                    p86, p87, p88, p89, p90, p91, p92, p103, p104
                }
            };

            var questionarioDPS_XP_M = new Questionario()
            {
                Id = 12,
                Descricao = "Declaração Pessoal de Saúde",
                DataUltimaAlteracao = DateTime.Now, /*alterar*/
                Tipo = new TipoQuestionario
                {
                    Id = (int)TipoQuestionarioEnum.DPS,
                    Descricao = TipoQuestionarioEnum.DPS.GetDescription()
                },
                Sexo = new Sexo()
                {
                    Id = (int)SexoEnum.Masculino,
                    Descricao = SexoEnum.Masculino.GetDescription()
                },
                RelacaoSegurado = new TipoRelacaoSegurado
                {
                    Id = (int)TipoRelacaoSeguradoEnum.Titular,
                    Descricao = TipoRelacaoSeguradoEnum.Titular.GetDescription(),
                },
                Perguntas = new List<ItemQuestionario>() {
                    p86, p87, p88, p89, p90, p91, p92, p103, p104
                }
            };

            #endregion XP

            #region XXX

            //
            var p187 = CriarPerguntaQuestionario(187, "Informe peso (_kg):", TipoRespostaEnum.Valor);
            var p188 = CriarPerguntaQuestionario(188, "Informe altura (_m):", TipoRespostaEnum.Valor);

            var p182 = CriarPerguntaQuestionarioSimNao(182, "Sofre de deficiência de órgãos, membros ou sentidos?");
            CriarSubPergunta(p182, 189, 1, "Informar quais:", TipoRespostaEnum.TextoLivre, 1);


            var p183 = CriarPerguntaQuestionarioSimNao(183, "Faz uso de algum medicamento?");
            CriarSubPergunta(p183, 190, 1, "Qual?", TipoRespostaEnum.TextoLivre, 1);

            var p185 = CriarPerguntaQuestionarioSimNao(185, "Está afastado(a) do trabalho?");

            var p186 = CriarPerguntaQuestionarioSimNao(186, "Pratica esportes e / ou atividades de risco?");
            CriarSubPergunta(p186, 191, 1, "Informar quais:", TipoRespostaEnum.TextoLivre, 1);


            //

            var questionarioXXX_M = new Questionario()
            {
                Id = 2,
                Descricao = "Declaração Pessoal de Saúde",
                DataUltimaAlteracao = DateTime.Now, /*alterar*/
                Tipo = new TipoQuestionario
                {
                    Id = (int)TipoQuestionarioEnum.DPS,
                    Descricao = TipoQuestionarioEnum.DPS.GetDescription()
                },
                Sexo = new Sexo()
                {
                    Id = (int)SexoEnum.Masculino,
                    Descricao = SexoEnum.Masculino.GetDescription()
                },
                RelacaoSegurado = new TipoRelacaoSegurado
                {
                    Id = (int)TipoRelacaoSeguradoEnum.Titular,
                    Descricao = TipoRelacaoSeguradoEnum.Titular.GetDescription(),
                },
                Perguntas = new List<ItemQuestionario>() {
                    p1.DeepClone(), p2.DeepClone(), p3.DeepClone(), p4.DeepClone(), p5.DeepClone(), p6.DeepClone(), p7.DeepClone(), p8.DeepClone(), p9.DeepClone(),
                    p10.DeepClone(),p11.DeepClone(),p12.DeepClone(),p13.DeepClone(),p89.DeepClone(), p90.DeepClone(), p91.DeepClone(), p92.DeepClone(),
                    p182.DeepClone(),p183.DeepClone(), p185.DeepClone(),p186.DeepClone(),p187.DeepClone(),p188.DeepClone(),p193.DeepClone()
                }
            };

            var questionarioXXX_F = new Questionario()
            {
                Id = 5,
                Descricao = "Declaração Pessoal de Saúde",
                DataUltimaAlteracao = DateTime.Now, /*alterar*/
                Tipo = new TipoQuestionario
                {
                    Id = (int)TipoQuestionarioEnum.DPS,
                    Descricao = TipoQuestionarioEnum.DPS.GetDescription()
                },
                Sexo = new Sexo()
                {
                    Id = (int)SexoEnum.Feminino,
                    Descricao = SexoEnum.Feminino.GetDescription()
                },
                RelacaoSegurado = new TipoRelacaoSegurado
                {
                    Id = (int)TipoRelacaoSeguradoEnum.Titular,
                    Descricao = TipoRelacaoSeguradoEnum.Titular.GetDescription(),
                },
                Perguntas = new List<ItemQuestionario>() {
                    p1.DeepClone(), p2.DeepClone(), p3.DeepClone(), p4.DeepClone(), p5.DeepClone(), p6.DeepClone(), p7.DeepClone(), p8.DeepClone(), p9.DeepClone(),
                    p10.DeepClone(),p11.DeepClone(),p12.DeepClone(),p13.DeepClone(),p89.DeepClone(), p90.DeepClone(), p91.DeepClone(), p92.DeepClone(),
                    p182.DeepClone(),p183.DeepClone(), p185.DeepClone(),p186.DeepClone(),p187.DeepClone(),p188.DeepClone() ,p193.DeepClone()
                }
            };


            #endregion XXX
            //  questionarios.Add("FA", new List<Questionario>() { questionarioFA_F, questionarioFA_M });
            //  questionarios.Add("FN", new List<Questionario>() { questionarioFN_F, questionarioFN_M });
            questionarios.Add("MB", new List<Questionario>() { questionarioMB_F, questionarioMB_M });
            //  questionarios.Add("GS", new List<Questionario>() { questionarioGS_F, questionarioGS_M });
            questionarios.Add("XXX", new List<Questionario>() { questionarioXXX_F, questionarioXXX_M });



            // XP Corretora de Seguros
            questionarios.Add("XP", new List<Questionario>() { questionarioHP_XP_F, questionarioHP_XP_M, questionarioDPS_XP_F, questionarioDPS_XP_M });

            PreencherIdLegado(questionarios);

            return questionarios;
        }

        private static void PreencherIdLegado(Dictionary<string, List<Questionario>> questionarios)
        {
            var jsonHmg = "[{\"modeloProposta\":\"FA\",\"questionarioId\":1,\"perguntaId\":3,\"legadoId\":24},{\"modeloProposta\":\"FA\",\"questionarioId\":1,\"perguntaId\":4,\"legadoId\":49},{\"modeloProposta\":\"FA\",\"questionarioId\":1,\"perguntaId\":5,\"legadoId\":50},{\"modeloProposta\":\"FA\",\"questionarioId\":1,\"perguntaId\":6,\"legadoId\":51},{\"modeloProposta\":\"FA\",\"questionarioId\":1,\"perguntaId\":7,\"legadoId\":52},{\"modeloProposta\":\"FA\",\"questionarioId\":1,\"perguntaId\":8,\"legadoId\":53},{\"modeloProposta\":\"FA\",\"questionarioId\":1,\"perguntaId\":9,\"legadoId\":54},{\"modeloProposta\":\"FA\",\"questionarioId\":2,\"perguntaId\":3,\"legadoId\":24},{\"modeloProposta\":\"FA\",\"questionarioId\":2,\"perguntaId\":4,\"legadoId\":49},{\"modeloProposta\":\"FA\",\"questionarioId\":2,\"perguntaId\":5,\"legadoId\":50},{\"modeloProposta\":\"FA\",\"questionarioId\":2,\"perguntaId\":6,\"legadoId\":51},{\"modeloProposta\":\"FA\",\"questionarioId\":2,\"perguntaId\":7,\"legadoId\":52},{\"modeloProposta\":\"FA\",\"questionarioId\":2,\"perguntaId\":8,\"legadoId\":53},{\"modeloProposta\":\"FA\",\"questionarioId\":2,\"perguntaId\":9,\"legadoId\":54},{\"modeloProposta\":\"FN\",\"questionarioId\":5,\"perguntaId\":3,\"legadoId\":48},{\"modeloProposta\":\"FN\",\"questionarioId\":5,\"perguntaId\":4,\"legadoId\":49},{\"modeloProposta\":\"FN\",\"questionarioId\":5,\"perguntaId\":5,\"legadoId\":50},{\"modeloProposta\":\"FN\",\"questionarioId\":5,\"perguntaId\":6,\"legadoId\":51},{\"modeloProposta\":\"FN\",\"questionarioId\":5,\"perguntaId\":7,\"legadoId\":52},{\"modeloProposta\":\"FN\",\"questionarioId\":5,\"perguntaId\":8,\"legadoId\":53},{\"modeloProposta\":\"FN\",\"questionarioId\":5,\"perguntaId\":9,\"legadoId\":54},{\"modeloProposta\":\"FN\",\"questionarioId\":6,\"perguntaId\":3,\"legadoId\":48},{\"modeloProposta\":\"FN\",\"questionarioId\":6,\"perguntaId\":4,\"legadoId\":49},{\"modeloProposta\":\"FN\",\"questionarioId\":6,\"perguntaId\":5,\"legadoId\":50},{\"modeloProposta\":\"FN\",\"questionarioId\":6,\"perguntaId\":6,\"legadoId\":51},{\"modeloProposta\":\"FN\",\"questionarioId\":6,\"perguntaId\":7,\"legadoId\":52},{\"modeloProposta\":\"FN\",\"questionarioId\":6,\"perguntaId\":8,\"legadoId\":53},{\"modeloProposta\":\"FN\",\"questionarioId\":6,\"perguntaId\":9,\"legadoId\":54},{\"modeloProposta\":\"GS\",\"questionarioId\":7,\"perguntaId\":3,\"legadoId\":48},{\"modeloProposta\":\"GS\",\"questionarioId\":7,\"perguntaId\":4,\"legadoId\":49},{\"modeloProposta\":\"GS\",\"questionarioId\":7,\"perguntaId\":5,\"legadoId\":50},{\"modeloProposta\":\"GS\",\"questionarioId\":7,\"perguntaId\":6,\"legadoId\":27},{\"modeloProposta\":\"GS\",\"questionarioId\":7,\"perguntaId\":7,\"legadoId\":52},{\"modeloProposta\":\"GS\",\"questionarioId\":7,\"perguntaId\":8,\"legadoId\":12},{\"modeloProposta\":\"GS\",\"questionarioId\":7,\"perguntaId\":9,\"legadoId\":54},{\"modeloProposta\":\"GS\",\"questionarioId\":8,\"perguntaId\":3,\"legadoId\":48},{\"modeloProposta\":\"GS\",\"questionarioId\":8,\"perguntaId\":4,\"legadoId\":49},{\"modeloProposta\":\"GS\",\"questionarioId\":8,\"perguntaId\":5,\"legadoId\":50},{\"modeloProposta\":\"GS\",\"questionarioId\":8,\"perguntaId\":6,\"legadoId\":51},{\"modeloProposta\":\"GS\",\"questionarioId\":8,\"perguntaId\":7,\"legadoId\":52},{\"modeloProposta\":\"GS\",\"questionarioId\":8,\"perguntaId\":8,\"legadoId\":53},{\"modeloProposta\":\"GS\",\"questionarioId\":8,\"perguntaId\":9,\"legadoId\":54}]";
            var jsonPrd = "[{\"modeloProposta\":\"FA\",\"questionarioId\":1,\"perguntaId\":3,\"legadoId\":24},{\"modeloProposta\":\"FA\",\"questionarioId\":1,\"perguntaId\":4,\"legadoId\":49},{\"modeloProposta\":\"FA\",\"questionarioId\":1,\"perguntaId\":5,\"legadoId\":50},{\"modeloProposta\":\"FA\",\"questionarioId\":1,\"perguntaId\":6,\"legadoId\":51},{\"modeloProposta\":\"FA\",\"questionarioId\":1,\"perguntaId\":7,\"legadoId\":52},{\"modeloProposta\":\"FA\",\"questionarioId\":1,\"perguntaId\":8,\"legadoId\":53},{\"modeloProposta\":\"FA\",\"questionarioId\":1,\"perguntaId\":9,\"legadoId\":54},{\"modeloProposta\":\"FA\",\"questionarioId\":2,\"perguntaId\":3,\"legadoId\":24},{\"modeloProposta\":\"FA\",\"questionarioId\":2,\"perguntaId\":4,\"legadoId\":49},{\"modeloProposta\":\"FA\",\"questionarioId\":2,\"perguntaId\":5,\"legadoId\":50},{\"modeloProposta\":\"FA\",\"questionarioId\":2,\"perguntaId\":6,\"legadoId\":51},{\"modeloProposta\":\"FA\",\"questionarioId\":2,\"perguntaId\":7,\"legadoId\":52},{\"modeloProposta\":\"FA\",\"questionarioId\":2,\"perguntaId\":8,\"legadoId\":53},{\"modeloProposta\":\"FA\",\"questionarioId\":2,\"perguntaId\":9,\"legadoId\":54},{\"modeloProposta\":\"FN\",\"questionarioId\":5,\"perguntaId\":3,\"legadoId\":48},{\"modeloProposta\":\"FN\",\"questionarioId\":5,\"perguntaId\":4,\"legadoId\":49},{\"modeloProposta\":\"FN\",\"questionarioId\":5,\"perguntaId\":5,\"legadoId\":50},{\"modeloProposta\":\"FN\",\"questionarioId\":5,\"perguntaId\":6,\"legadoId\":51},{\"modeloProposta\":\"FN\",\"questionarioId\":5,\"perguntaId\":7,\"legadoId\":52},{\"modeloProposta\":\"FN\",\"questionarioId\":5,\"perguntaId\":8,\"legadoId\":53},{\"modeloProposta\":\"FN\",\"questionarioId\":5,\"perguntaId\":9,\"legadoId\":54},{\"modeloProposta\":\"FN\",\"questionarioId\":6,\"perguntaId\":3,\"legadoId\":48},{\"modeloProposta\":\"FN\",\"questionarioId\":6,\"perguntaId\":4,\"legadoId\":49},{\"modeloProposta\":\"FN\",\"questionarioId\":6,\"perguntaId\":5,\"legadoId\":50},{\"modeloProposta\":\"FN\",\"questionarioId\":6,\"perguntaId\":6,\"legadoId\":51},{\"modeloProposta\":\"FN\",\"questionarioId\":6,\"perguntaId\":7,\"legadoId\":52},{\"modeloProposta\":\"FN\",\"questionarioId\":6,\"perguntaId\":8,\"legadoId\":53},{\"modeloProposta\":\"FN\",\"questionarioId\":6,\"perguntaId\":9,\"legadoId\":54},{\"modeloProposta\":\"GS\",\"questionarioId\":7,\"perguntaId\":3,\"legadoId\":48},{\"modeloProposta\":\"GS\",\"questionarioId\":7,\"perguntaId\":4,\"legadoId\":49},{\"modeloProposta\":\"GS\",\"questionarioId\":7,\"perguntaId\":5,\"legadoId\":50},{\"modeloProposta\":\"GS\",\"questionarioId\":7,\"perguntaId\":6,\"legadoId\":27},{\"modeloProposta\":\"GS\",\"questionarioId\":7,\"perguntaId\":7,\"legadoId\":52},{\"modeloProposta\":\"GS\",\"questionarioId\":7,\"perguntaId\":8,\"legadoId\":12},{\"modeloProposta\":\"GS\",\"questionarioId\":7,\"perguntaId\":9,\"legadoId\":54},{\"modeloProposta\":\"GS\",\"questionarioId\":8,\"perguntaId\":3,\"legadoId\":48},{\"modeloProposta\":\"GS\",\"questionarioId\":8,\"perguntaId\":4,\"legadoId\":49},{\"modeloProposta\":\"GS\",\"questionarioId\":8,\"perguntaId\":5,\"legadoId\":50},{\"modeloProposta\":\"GS\",\"questionarioId\":8,\"perguntaId\":6,\"legadoId\":51},{\"modeloProposta\":\"GS\",\"questionarioId\":8,\"perguntaId\":7,\"legadoId\":52},{\"modeloProposta\":\"GS\",\"questionarioId\":8,\"perguntaId\":8,\"legadoId\":53},{\"modeloProposta\":\"GS\",\"questionarioId\":8,\"perguntaId\":9,\"legadoId\":54}]";
            string json = "";
            if(Environment.GetEnvironmentVariable("Ambiente") == "HMG")
            {
                json = jsonHmg;
            }
            else
            {
                json = jsonPrd;
            }
            var referencias = JsonConvert.DeserializeObject<List<ReferenciaQuestionarioLegado>>(json);

            foreach (var referencia in referencias)
            {
                if (!questionarios.ContainsKey(referencia.ModeloProposta))
                    continue;

                var lista = questionarios[referencia.ModeloProposta];
                var questionario = lista.FirstOrDefault(q => q.Id == referencia.QuestionarioId);

                if (questionario == null)
                    continue;

                var pergunta = questionario.Perguntas.FirstOrDefault(p => p.Id == referencia.PerguntaId) as PerguntaQuestionario;

                if (pergunta == null)
                    continue;

                pergunta.IdLegado = referencia.LegadoId;
            }
        }

        private static PerguntaQuestionario CriarPerguntaQuestionarioSimNao(int id, string descricao)
        {
            PerguntaQuestionario perguntaQuestionario = new PerguntaQuestionario()
            {
                Id = id,
                Descricao = descricao,
                TipoResposta = new TipoResposta
                {
                    Id = (int)TipoRespostaEnum.SimNao,
                    Descricao = TipoRespostaEnum.SimNao.GetDescription()
                },
                Tipo = new TipoItemQuestionario()
                {
                    Id = (int)TipoItemQuestionarioEnum.Pergunta,
                    Descricao = TipoItemQuestionarioEnum.Pergunta.GetDescription()
                },
                TipoVariacaoResposta = new TipoVariacaoResposta
                {
                    Id = (int)TipoVariacaoRespostaEnum.SelecaoUnica,
                    Descricao = TipoVariacaoRespostaEnum.SelecaoUnica.GetDescription()
                },
                Dominio = new List<DominioResposta>()
                        {
                            new DominioResposta()
                            {
                                Id = 1,
                                Descricao = "Sim"
                            },
                            new DominioResposta()
                            {
                                Id = 2,
                                Descricao = "Não",
                            }
                        }
            };

            return perguntaQuestionario;
        }

        private static PerguntaQuestionario CriarPerguntaQuestionarioValor(PerguntaQuestionario p)
        {
            PerguntaQuestionario perguntaQuestionario = new PerguntaQuestionario()
            {
                Id = p.Id,
                Descricao = p.Descricao,
                Tipo = new TipoItemQuestionario()
                {
                    Id = (int)TipoItemQuestionarioEnum.Pergunta,
                    Descricao = TipoItemQuestionarioEnum.Pergunta.GetDescription()
                },
                TipoResposta = new TipoResposta
                {
                    Id = (int)TipoRespostaEnum.SimNao,
                    Descricao = TipoRespostaEnum.SimNao.GetDescription()
                },
                TipoVariacaoResposta = new TipoVariacaoResposta
                {
                    Id = (int)TipoVariacaoRespostaEnum.SelecaoUnica,
                    Descricao = TipoVariacaoRespostaEnum.SelecaoUnica.GetDescription()
                },
                Dominio = new List<DominioResposta>()
                        {
                            new DominioResposta()
                            {
                                Id = 1,
                                Descricao = "Sim"
                            },
                            new DominioResposta()
                            {
                                Id = 2,
                                Descricao = "Não",
                            }
                        }
            };

            return perguntaQuestionario;
        }

        private static PerguntaQuestionario CriarPerguntaQuestionario(int id, string descricao, TipoRespostaEnum tipoResposta)
        {
            PerguntaQuestionario perguntaQuestionario = new PerguntaQuestionario()
            {
                Id = id,
                Descricao = descricao,
                Tipo = new TipoItemQuestionario()
                {
                    Id = (int)TipoItemQuestionarioEnum.Pergunta,
                    Descricao = TipoItemQuestionarioEnum.Pergunta.GetDescription()
                },
                TipoResposta = new TipoResposta
                {
                    Id = (int)tipoResposta,
                    Descricao = tipoResposta.GetDescription()
                }
            };

            return perguntaQuestionario;
        }

        private static AgrupadorQuestionario CriarAgrupadorQuestionario(int id, string descricao)
        {
            AgrupadorQuestionario perguntaQuestionario = new AgrupadorQuestionario()
            {
                Id = id,
                Tipo = new TipoItemQuestionario()
                {
                    Id = (int)TipoItemQuestionarioEnum.Agrupador,
                    Descricao = TipoItemQuestionarioEnum.Agrupador.GetDescription()
                },
                Descricao = descricao
            };

            return perguntaQuestionario;
        }
    }

    public static class ExtensionMethods
    {
        // Deep clone
        public static T DeepClone<T>(this T a)
        {
            var json = JsonConvert.SerializeObject(a);
            return JsonConvert.DeserializeObject<T>(json);
        }
    }
}

