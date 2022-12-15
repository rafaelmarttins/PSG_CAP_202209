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
    public class FuncionarioService : GenericService<Funcionario, FuncionarioPoco>
    {
        public FuncionarioService(ExameCAPContext context) : base(context)
        { }

        public override List<FuncionarioPoco> Consultar(Expression<Func<Funcionario, bool>>? predicate = null)
        {
            IQueryable<Funcionario> query;
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

        public override List<FuncionarioPoco> Listar(int? take = null, int? skip = null)
        {
            IQueryable<Funcionario> query;
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

        public override List<FuncionarioPoco> ConverterPara(IQueryable<Funcionario> query)
        {
            return query.Select(fun =>
                    new FuncionarioPoco()
                    {
                        CodigoFuncionario = fun.CodigoFuncionario,
                        Nome = fun.Nome,
                        Email = fun.Email,
                        Telefone = fun.Telefone,
                        Usuario = fun.Usuario,
                        Senha = fun.Senha,
                        Matricula = fun.Matricula,
                        ContaCorrente = fun.ContaCorrente,
                        DataNascimento = fun.DataNascimento,
                    }
            )
            .ToList();
        }
    }
}

