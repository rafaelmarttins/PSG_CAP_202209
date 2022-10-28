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
    public class ColaboradorServico : BaseServico<ColaboradorPoco, Colaborador>
    {
        private ColaboradorRepo repo;

        public ColaboradorServico() : base()
        {
            this.repo = new ColaboradorRepo();
        }

        public override ColaboradorPoco Add(ColaboradorPoco poco)
        {
            Colaborador nova = this.ConvertTo(poco);
            Colaborador criada = this.repo.Create(nova);
            ColaboradorPoco criadaPoco = this.ConvertTo(criada);
            return criadaPoco;
        }

        public override List<ColaboradorPoco> Browse()
        {
            List<ColaboradorPoco> listaPoco = this.repo.Read()
                .Select(col =>
                    new ColaboradorPoco()
                    {
                        Ctps = col.Ctps,
                        Pis = col.Pis,
                        TituloEleitor = col.TituloEleitor,
                        Reservista = col.Reservista,
                        EstadoCivil = col.EstadoCivil,
                        NumDependentes = col.NumDependentes,
                        Ativo = col.Ativo,
                        Setor = col.Setor,
                        Cargo = col.Cargo,
                        Salario = col.Salario,
                        Telefone1 = col.Telefone1,
                        Telefone2 = col.Telefone2
                    }
                 )
                .ToList();
            return listaPoco;
        }

        public override ColaboradorPoco ConvertTo(Colaborador dominio)
        {
            return new ColaboradorPoco()
            {
                Ctps = dominio.Ctps,
                Pis = dominio.Pis,
                TituloEleitor = dominio.TituloEleitor,
                Reservista = dominio.Reservista,
                EstadoCivil = dominio.EstadoCivil,
                NumDependentes = dominio.NumDependentes,
                Ativo = dominio.Ativo,
                Setor = dominio.Setor,
                Cargo = dominio.Cargo,
                Salario = dominio.Salario,
                Telefone1 = dominio.Telefone1,
                Telefone2 = dominio.Telefone2
            };
        }

        public override Colaborador ConvertTo(ColaboradorPoco poco)
        {
            return new Colaborador()
            {
                Ctps = poco.Ctps,
                Pis = poco.Pis,
                TituloEleitor = poco.TituloEleitor,
                Reservista = poco.Reservista,
                EstadoCivil = poco.EstadoCivil,
                NumDependentes = poco.NumDependentes,
                Ativo = poco.Ativo,
                Setor = poco.Setor,
                Cargo = poco.Cargo,
                Salario = poco.Salario,
                Telefone1 = poco.Telefone1,
                Telefone2 = poco.Telefone2
            };
        }

        public override ColaboradorPoco Delete(int chave)
        {
            Colaborador del = this.repo.Delete(chave);
            ColaboradorPoco delPoco = this.ConvertTo(del);
            return delPoco;
        }

        public override ColaboradorPoco Delete(ColaboradorPoco poco)
        {
            Colaborador del = this.repo.Delete(ConvertTo(poco));
            ColaboradorPoco delPoco = this.ConvertTo(del);
            return delPoco;
        }

        public override ColaboradorPoco Edit(ColaboradorPoco poco)
        {
            Colaborador editada = this.ConvertTo(poco);
            Colaborador alterada = this.repo.Update(editada);
            ColaboradorPoco alteradaPoco = this.ConvertTo(alterada);
            return alteradaPoco;
        }

        public override ColaboradorPoco Read(int chave)
        {
            Colaborador lida = this.repo.Read(chave);
            ColaboradorPoco lidaPoco = this.ConvertTo(lida);
            return lidaPoco;
        }
    }
}
