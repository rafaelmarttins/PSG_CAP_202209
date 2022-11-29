﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica.Dominio.EF
{
    [Table("Consulta", Schema = "dbo")]
    public partial class Consulta
    {
        [Key]
        public int CodigoConsulta { get; set; }

        [Column(name: "Historico")]
        [Unicode(false)]
        public string Historico { get; set; } = null!;

        [Column(name: "Data", TypeName = "date")]
        public DateTime Data { get; set; }

        [Column(name: "Hora", TypeName = "time")]
        public TimeSpan Hora { get; set; }

        [Column(name: "DataHora", TypeName = "datetime")]
        public DateTime DataHora { get; set; }

        [Column(name: "Situacao")]
        public bool? Situacao { get; set; }

        [Column(name: "DataInclusao", TypeName = "datetime")]
        public DateTime? DataInclusao { get; set; }

        [Column(name: "DataAlteracao", TypeName = "datetime")]
        public DateTime? DataAlteracao { get; set; }
    }
}
