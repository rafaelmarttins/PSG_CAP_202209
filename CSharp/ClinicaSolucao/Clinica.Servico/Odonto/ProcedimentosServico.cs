using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Clinica.Dominio.EF;
using Clinica.Poco;
using Clinica.Servico.Base;

namespace Clinica.Servico.Odonto
{
    public class ProcedimentosServico : GenericService<Clinica.Dominio.EF.Servico, ServicoPoco>
    {
        public ProcedimentosServico(ClinicaContext contex) : base(contex)
        { }

        public override List<ServicoPoco> Consultar(Expression<Func<Clinica.Dominio.EF.Servico, bool>>? predicate = null)
        {
            IQueryable<Clinica.Dominio.EF.Servico> query;
            if (predicate == null)
            {
                query = this.genrepo.Browseable(null);
            }
            else
            {
                query = this.genrepo.Browseable(predicate);
            }
            return this.ConverterPara(query);
        }

        public override List<ServicoPoco> Listar(int? take = null, int? skip = null)
        {
            IQueryable<Clinica.Dominio.EF.Servico> query;
            if (skip == null)
            {
                query = this.genrepo.GetAll();
            }
            else
            {
                query = this.genrepo.GetAll(take, skip);
            }
            return ConverterPara(query);
        }

        public override List<ServicoPoco> Vasculhar(int? take = null, int? skip = null, Expression<Func<Dominio.EF.Servico, bool>>? predicate = null)
        {
            IQueryable<Clinica.Dominio.EF.Servico> query;
            if (skip == null)
            {
                if (predicate == null)
                {
                    query = this.genrepo.Browseable(null);
                }
                else
                {
                    query = this.genrepo.Browseable(predicate);
                }
            }
            else
            {
                if(predicate == null)
                {
                    query = this.genrepo.GetAll(take, skip);
                }
                else
                {
                    query = this.genrepo.Searchable(take, skip, predicate);
                }
            }
            return this.ConverterPara(query);
        }

        public override List<ServicoPoco> ConverterPara(IQueryable<Dominio.EF.Servico> query)
        {
            return query.Select(pce =>
                    new ServicoPoco()
                    {
                        CodigoServico = pce.CodigoServico,
                        DataAlteracao = pce.DataAlteracao,
                        DataInclusao = pce.DataInclusao,
                        Descricao = pce.Descricao,
                        MedidaPreventiva = pce.MedidaPreventiva,
                        Preco = pce.Preco,
                        Situacao = pce.Situacao,
                        TipoExame = pce.TipoExame,
                        TipoServico = pce.TipoServico,
                        DenteTratado = pce.DenteTratado,
                        MaterialUsado = pce.MedidaPreventiva,
                        DenteCanalPar = pce.DenteCanalPar,
                        DenteExtraido = pce.DenteExtraido,
                        CodigoTipoServico = pce.CodigoTipoServico
                    }
            )
            .ToList();
        }
    }
}
