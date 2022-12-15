using ExameCAP.Dominio.EF;
using ExameCAP.Poco;
using ExameCAP.Service.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ExameCAP.Service.Exame
{
    public class PassageiroService : GenericService<Passageiro, PassageiroPoco>
    {
        public PassageiroService(ExameCAPContext context) : base(context)
        { }

        public override List<PassageiroPoco> Consultar(Expression<Func<Passageiro, bool>>? predicate = null)
        {
            IQueryable<Passageiro> query;
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

        public override List<PassageiroPoco> Listar(int? take = null, int? skip = null)
        {
            IQueryable<Passageiro> query;
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

        public override List<PassageiroPoco> ConverterPara(IQueryable<Passageiro> query)
        {
            return query.Select(pas =>
                    new PassageiroPoco()
                    {
                        CodigoPassageiro = pas.CodigoPassageiro,
                        Nome = pas.Nome,
                        Email = pas.Email,
                        Telefone = pas.Telefone,
                        Usuario = pas.Usuario,
                        Senha = pas.Senha,
                        Documento = pas.Documento,
                        NumeroCartao = pas.NumeroCartao,
                        DataNascimento = pas.DataNascimento,
                    }
            )
            .ToList();
        }
    }
}
