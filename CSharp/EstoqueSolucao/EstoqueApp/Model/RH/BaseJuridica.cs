using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstoqueApp.Model.RH
{
    public abstract class BaseJuridica : BasePessoa
    {
        protected string nome;

        protected string nomeFantasia;

        protected string razaoSocial;

        protected string cpnj;

        protected string inscricaoEstadual;

        protected DateTime fundacao;

        protected string emailCorporativo;

        public string Nome { get => nome; set => nome = value; }
        public string NomeFantasia { get => nomeFantasia; set => nomeFantasia = value; }
        public string RazaoSocial { get => razaoSocial; set => razaoSocial = value; }
        public string Cpnj { get => cpnj; set => cpnj = value; }
        public string InscricaoEstadual { get => inscricaoEstadual; set => inscricaoEstadual = value; }
        public DateTime Fundacao { get => fundacao; set => fundacao = value; }
        public string EmailCorporativo { get => emailCorporativo; set => emailCorporativo = value; }

        public BaseJuridica() : base()
        {
        }

        public BaseJuridica(int id, string nome, string nomeFantasia, string razaoSocial, string cpnj, string inscricaoEstadual, DateTime fundacao, string emailCorporativo) : base(id)
        {
            this.nome = nome;
            this.nomeFantasia = nomeFantasia;
            this.razaoSocial = razaoSocial;
            this.cpnj = cpnj;
            this.inscricaoEstadual = inscricaoEstadual;
            this.fundacao = fundacao;
            this.emailCorporativo = emailCorporativo;
        }
    }
}
