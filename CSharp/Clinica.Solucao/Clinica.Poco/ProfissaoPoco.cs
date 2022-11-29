﻿namespace Clinica.Poco
{
    public class ProfissaoPoco
    {
        public int CodigoProfissao { get; set; }
        public string Descricao { get; set; } = null!;
        public DateTime? DataInclusao { get; set; }
        public bool? Situacao { get; set; }

        public ProfissaoPoco()
        { }
    }
}
