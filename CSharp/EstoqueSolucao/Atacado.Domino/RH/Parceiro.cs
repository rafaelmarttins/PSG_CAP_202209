using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atacado.Dominio.RH
{
    public class Parceiro : BaseJuridica
    {
        private double desempenho;

        private string setor;

        private double comissao;

        public double Desempenho { get => desempenho; set => desempenho = value; }
        public string Setor { get => setor; set => setor = value; }
        public double Comissao { get => comissao; set => comissao = value; }

        public Parceiro() : base()
        { }

        public Parceiro(int id, string nome, string nomeFantasia, string razaoSocial, string cpnj, string inscricaoEstadual,
            DateTime fundacao, string emailCorporativo, double desempenho, string setor, double comissao)
            : base(id, nome, nomeFantasia, razaoSocial, cpnj, inscricaoEstadual, fundacao, emailCorporativo)
        {
            this.desempenho = desempenho;
            this.setor = setor;
            this.comissao = comissao;
        }
    }
}
