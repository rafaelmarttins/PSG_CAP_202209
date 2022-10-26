using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Atacado.DB.FakeDB.RH;
using Atacado.Dominio.RH;
using Atacado.Repositorio.Base;

namespace Atacado.Repositorio.RH
{
    public class ParceiroRepo : BaseRepositorio<Parceiro>
    {
        private RHContexto contexto;

        public ParceiroRepo()
        {
            this.contexto = new RHContexto();
        }

        public override Parceiro Create(Parceiro instancia)
        {
            return this.contexto.AddParceiro(instancia);
        }

        public override Parceiro Delete(int chave)
        {
            Parceiro del = this.Read(chave);
            if (this.contexto.Parceiros.Remove(del) == false)
            {
                return null;
            }
            else
            {
                return del;
            }
        }

        public override Parceiro Delete(Parceiro instancia)
        {
            return this.Delete(instancia.Id);
        }

        public override Parceiro Read(int chave)
        {
            return this.contexto.Parceiros.SingleOrDefault(par => par.Id == chave);
        }

        public override List<Parceiro> Read()
        {
            return this.contexto.Parceiros;
        }

        public override Parceiro Update(Parceiro instancia)
        {
            Parceiro atu = this.Read(instancia.Id);
            if (atu == null)
            {
                return null;
            }
            else
            {
                atu.Desempenho = instancia.Desempenho;
                atu.Setor = instancia.Setor;
                atu.Comissao = instancia.Comissao;

                return atu;
            }
        }
    }
}
