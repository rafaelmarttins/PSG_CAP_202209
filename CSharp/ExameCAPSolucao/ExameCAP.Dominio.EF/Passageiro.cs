using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ExameCAP.Dominio.EF
{
    [Table("Passageiro", Schema = "dbo")]
    public partial class Passageiro
    {
        [Key]
        [Column(name: "CodigoPassageiro")]
        public int CodigoPassageiro { get; set; }

        [Column(name: "Nome")]
        public string Nome { get; set; } = null!;

        [Column(name: "Email")]
        public string Email { get; set; } = null!;

        [Column(name: "Telefone")]
        public string Telefone { get; set; } = null!;

        [Column(name: "Usuario")]
        public string Usuario { get; set; } = null!;

        [Column(name: "Senha")]
        public string Senha { get; set; } = null!;

        [Column(name: "Documento")]
        public string Documento { get; set; } = null!;

        [Column(name: "NumeroCartao")]
        public string NumeroCartao { get; set; } = null!;

        [Column(name: "DataNascimento", TypeName = "datetime")]
        public DateTime DataNascimento { get; set; }

        [Column(name: "Situacao")]
        public bool? Situacao { get; set; }
    }
}