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
    [Table("Funcionario", Schema = "dbo")]
    public partial class Funcionario
    {
        [Key]
        [Column(name: "CodigoFuncionario")]
        public int CodigoFuncionario { get; set; }

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

        [Column(name: "Matricula")]
        public string Matricula { get; set; } = null!;

        [Column(name: "ContaCorrente")]
        public string ContaCorrente { get; set; } = null!;

        [Column(name: "DataNascimento", TypeName = "datetime")]
        public DateTime DataNascimento { get; set; }

        [Column(name: "Situacao")]
        public bool? Situacao { get; set; }
    }
}