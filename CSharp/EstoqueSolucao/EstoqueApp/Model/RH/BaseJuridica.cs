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

    }
}
