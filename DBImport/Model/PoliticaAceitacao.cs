using System;
using System.Collections.Generic;

namespace Api.Engines.Venda.Model
{
    public class PoliticaAceitacao
    {
        public int? Id { get; set; }
        public DateTime? DataUltimaAlteracao { get; set; }
        public int? ImcMinimoRecusa { get; set; }
        public int? ImcMaximoRecusa { get; set; }
        public int? ImcMinimoExame { get; set; }
        public int? ImcMaximoExame { get; set; }
        public int? CigarrosRecusa { get; set; }
        public int? CigarrosExame { get; set; }
        public List<LimiteOperacionalProfissao> LimitesOperacionaisPorProfissao { get; set; }
        public List<LimiteOperacionalRenda> LimitesOperacionaisPorRenda { get; set; }
        public List<LimiteOperacionalFaixaEtaria> LimitesOperacionaisPorFaixaEtaria { get; set; }
    }
}
