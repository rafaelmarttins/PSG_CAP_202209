using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExameCAP.Poco
{
    public class PassageiroPoco
    {
        public int CodigoPassageiro { get; set; }
        public string Nome { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Telefone { get; set; } = null!;
        public string Usuario { get; set; } = null!;
        public string Senha { get; set; } = null!;
        public string Documento { get; set; } = null!;
        public string NumeroCartao { get; set; } = null!;
        public DateTime DataNascimento { get; set; }

        public PassageiroPoco()
        { }
    }
}
