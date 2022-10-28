using Atacado.DB.FakeDB.FrotaAtacado;
using Atacado.Dominio.FrotaAtacado;
using Atacado.Repositorio.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atacado.Repositorio.FrotaAtacado
{
    public class UtilitarioRepo : BaseRepositorio<Utilitario>
    {
        private FrotaAtacadoContexto contexto;
        public UtilitarioRepo()
        {
            this.contexto = new FrotaAtacadoContexto();
        }

        public override Utilitario Create(Utilitario instancia)
        {
            return this.contexto.AddUtilitario(instancia);
        }

        public override Utilitario Delete(int chave)
        {
            Utilitario del = this.Read(chave);
            if (this.contexto.Utilitarios.Remove(del) == false)
            {
                return null;
            }
            else
            {
                return del;
            }
        }

        public override Utilitario Delete(Utilitario instancia)
        {
            return this.Delete(instancia.Codigo);
        }

        public override Utilitario Read(int chave)
        {
            return this.contexto.Utilitarios.SingleOrDefault(col => col.Codigo == chave);
        }

        public override List<Utilitario> Read()
        {
            return this.contexto.Utilitarios;
        }

        public override Utilitario Update(Utilitario instancia)
        {
            Utilitario atu = this.Read(instancia.Codigo);
            if (atu == null)
            {
                return null;
            }
            else
            {
                atu.Ativo = instancia.Ativo;
                atu.DataInclusao = instancia.DataInclusao;
                atu.Chassi = instancia.Chassi;
                atu.Cor = instancia.Cor;
                atu.Marca = instancia.Marca;
                atu.Modelo = instancia.Modelo;
                atu.Placa = instancia.Placa;
                atu.PesoBruto = instancia.PesoBruto;
                atu.PesoLiquido = instancia.PesoLiquido;
                atu.PesoTotal = instancia.PesoTotal;
                return atu;
            }
        }
    }
}
