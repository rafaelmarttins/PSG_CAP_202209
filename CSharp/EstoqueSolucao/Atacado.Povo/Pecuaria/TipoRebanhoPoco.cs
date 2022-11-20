﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atacado.Poco.Pecuaria
{
    public class TipoRebanhoPoco
    {
        public int CodigoTipo { get; set; }
        public string Descricao { get; set; } = null!;
        public bool? Situacao { get; set; }
        public DateTime? DataInclusao { get; set; }
        public DateTime? DataAlteracao { get; set; }
        public DateTime? DataExclusao { get; set; }

        public TipoRebanhoPoco()
        { }
    }
}
