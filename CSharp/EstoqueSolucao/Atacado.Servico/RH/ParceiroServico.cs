using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Atacado.Dominio.RH;
using Atacado.Poco.RH;
using Atacado.Repositorio.RH;
using Atacado.Servico.Base;

namespace Atacado.Servico.RH
{
    public class ParceiroServico : BaseServico<ParceiroPoco, Parceiro>
    {
        private ParceiroRepo repo;

        public ParceiroServico() : base()
        {
            this.repo = new ParceiroRepo();
        }

        public override ParceiroPoco Add(ParceiroPoco poco)
        {
            Parceiro nova = this.ConvertTo(poco);
            Parceiro criada = this.repo.Create(nova);
            ParceiroPoco criadaPoco = this.ConvertTo(criada);
            return criadaPoco;
        }

        public override List<ParceiroPoco> Browse()
        {
            List<ParceiroPoco> listaPoco = this.repo.Read()
                .Select(par =>
                    new ParceiroPoco()
                    {
                        Desempenho = par.Desempenho,
                        Setor = par.Setor,
                        Comissao = par.Comissao,
                    }
                 )
                .ToList();
            return listaPoco;
        }

        public override ParceiroPoco ConvertTo(Parceiro dominio)
        {
            return new ParceiroPoco()
            {
                Desempenho = dominio.Desempenho,
                Setor = dominio.Setor,
                Comissao = dominio.Comissao,
            };
        }

        public override Parceiro ConvertTo(ParceiroPoco poco)
        {
            return new Parceiro()
            {
                Desempenho = poco.Desempenho,
                Setor = poco.Setor,
                Comissao = poco.Comissao,
            };
        }

        public override ParceiroPoco Delete(int chave)
        {
            Parceiro del = this.repo.Delete(chave);
            ParceiroPoco delPoco = this.ConvertTo(del);
            return delPoco;
        }

        public override ParceiroPoco Delete(ParceiroPoco poco)
        {
            Parceiro del = this.repo.Delete(ConvertTo(poco));
            ParceiroPoco delPoco = this.ConvertTo(del);
            return delPoco;
        }

        public override ParceiroPoco Edit(ParceiroPoco poco)
        {
            Parceiro editada = this.ConvertTo(poco);
            Parceiro alterada = this.repo.Update(editada);
            ParceiroPoco alteradaPoco = this.ConvertTo(alterada);
            return alteradaPoco;
        }

        public override ParceiroPoco Read(int chave)
        {
            Parceiro lida = this.repo.Read(chave);
            ParceiroPoco lidaPoco = this.ConvertTo(lida);
            return lidaPoco;
        }
    }
}
