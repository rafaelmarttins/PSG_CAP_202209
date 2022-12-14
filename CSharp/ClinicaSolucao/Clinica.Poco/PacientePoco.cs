﻿namespace Clinica.Poco
{
    public class PacientePoco
    {
        public int CodigoPaciente { get; set; }
        public string Nome { get; set; } = null!;
        public string Endereco { get; set; } = null!;
        public string Telefone { get; set; } = null!;
        public DateTime DataDeNascimento { get; set; }
        public int CodigoProfissao { get; set; }
        public string? RG { get; set; } = null!;
        public string? CPF { get; set; } = null!;
        public bool? Situacao { get; set; }
        public DateTime? DataInclusao { get; set; }
        public DateTime? DataAlteracao { get; set; }

        public PacientePoco()
        { }
    }
}
