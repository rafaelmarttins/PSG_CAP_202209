﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExameCAP.Poco
{
    public class PessoaPoco
    {
        public int CodigoFuncionario { get; set; }
        public string Nome { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Telefone { get; set; } = null!;
        public string Usuario { get; set; } = null!;
        public string Senha { get; set; } = null!;
        public string Matricula { get; set; } = null!;
        public string ContaCorrente { get; set; } = null!;
        public string Matricula { get; set; } = null!;
        public string ContaCorrente { get; set; } = null!;
        public DateTime DataNascimento { get; set; }
        public bool? Situacao { get; set; }
    }
}
