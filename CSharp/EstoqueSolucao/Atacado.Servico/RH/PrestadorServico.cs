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
    public class PrestadorServico : BaseServico<PrestadorPoco, Prestador>
    {
        private PrestadorRepo repo;

        public PrestadorServico() : base()
        {
            this.repo = new PrestadorRepo();
        }

        public override PrestadorPoco Add(PrestadorPoco poco)
        {
            Prestador nova = this.ConvertTo(poco);
            Prestador criada = this.repo.Create(nova);
            PrestadorPoco criadaPoco = this.ConvertTo(criada);
            return criadaPoco;
        }

        public override List<PrestadorPoco> Browse()
        {
            List<PrestadorPoco> listaPoco = this.repo.Read()
                .Select(pre =>
                    new PrestadorPoco()
                    {
                        DataContratoInicial = pre.DataContratoInicial,
                        DataContratoFinal = pre.DataContratoFinal,
                    }
                 )
                .ToList();
            return listaPoco;
        }

        public override PrestadorPoco ConvertTo(Prestador dominio)
        {
            return new PrestadorPoco()
            {
                DataContratoInicial = dominio.DataContratoInicial,
                DataContratoFinal = dominio.DataContratoFinal,
            };
        }

        public override Prestador ConvertTo(PrestadorPoco poco)
        {
            return new Prestador()
            {
                DataContratoInicial = poco.DataContratoInicial,
                DataContratoFinal = poco.DataContratoFinal,
            };
        }

        public override PrestadorPoco Delete(int chave)
        {
            Prestador del = this.repo.Delete(chave);
            PrestadorPoco delPoco = this.ConvertTo(del);
            return delPoco;
        }

        public override PrestadorPoco Delete(PrestadorPoco poco)
        {
            Prestador del = this.repo.Delete(ConvertTo(poco));
            PrestadorPoco delPoco = this.ConvertTo(del);
            return delPoco;
        }

        public override PrestadorPoco Edit(PrestadorPoco poco)
        {
            Prestador editada = this.ConvertTo(poco);
            Prestador alterada = this.repo.Update(editada);
            PrestadorPoco alteradaPoco = this.ConvertTo(alterada);
            return alteradaPoco;
        }

        public override PrestadorPoco Read(int chave)
        {
            Prestador lida = this.repo.Read(chave);
            PrestadorPoco lidaPoco = this.ConvertTo(lida);
            return lidaPoco;
        }
    }
}
