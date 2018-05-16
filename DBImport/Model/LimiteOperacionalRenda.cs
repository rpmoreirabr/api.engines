﻿using System.Collections.Generic;

namespace Api.Engines.Venda.Model
{
    public class LimiteOperacionalRenda : Limite
    {        
        public int? IdadeInicial { get; set; }
        public int? IdadeFinal { get; set; }
        public int? MultiploRenda { get; set; }
    }
}