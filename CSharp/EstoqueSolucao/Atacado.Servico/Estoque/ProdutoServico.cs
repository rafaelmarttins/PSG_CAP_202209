using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Atacado.Servico.Base;
using Atacado.DB.EF.Database;
using Atacado.Poco.Estoque;
using Atacado.Repositorio.Base;
using System.Linq.Expressions;

namespace Atacado.Servico.Estoque
{
    public class ProdutoServico : BaseServico<ProdutoPoco, Produto>
    {
        private GenericRepository<Produto> genrepo;

        public ProdutoServico() : base()
        {
            this.genrepo = new GenericRepository<Produto>();
        }

        public override ProdutoPoco Add(ProdutoPoco poco)
        {
            Produto nova = this.ConvertTo(poco);
            Produto criada = this.genrepo.Insert(nova);
            ProdutoPoco criadaPoco = this.ConvertTo(criada);
            return criadaPoco;
        }

        public override List<ProdutoPoco> Browse()
        {
            return this.Browse(null);
        }

        public override List<ProdutoPoco> Browse(Expression<Func<Produto, bool>> filtro = null)
        {
            List<ProdutoPoco> listPoco;
            IQueryable<Produto> query;
            if (filtro == null)
            {
                query = this.genrepo.Browseable(null);
            }
            else
            {
                query = this.genrepo.Browseable(filtro);
            }
            listPoco = query.Select(pro =>
                    new ProdutoPoco()
                    {
                        Codigo = pro.Codigo,
                        Descricao = pro.Descricao,
                        Ativo = pro.Ativo,
                        DataInsert = pro.DataInsert,
                        CodigoCategoria = pro.CodigoCategoria,
                        CodigoSubcategoria = pro.CodigoSubcategoria
                    }
            )
            .ToList();
            return listPoco;
        }
        public override ProdutoPoco ConvertTo(Produto dominio)
        {
            return new ProdutoPoco()
            {
                Codigo = dominio.Codigo,
                Descricao = dominio.Descricao,
                Ativo = dominio.Ativo,
                DataInsert = dominio.DataInsert,
                CodigoCategoria = dominio.CodigoCategoria,
                CodigoSubcategoria = dominio.CodigoSubcategoria
            };
        }

        public override Produto ConvertTo(ProdutoPoco poco)
        {
            return new Produto()
            {
                Codigo = poco.Codigo,
                Descricao = poco.Descricao,
                Ativo = poco.Ativo,
                DataInsert = poco.DataInsert,
                CodigoCategoria = poco.CodigoCategoria,
                CodigoSubcategoria = poco.CodigoSubcategoria
            };
        }

        public override ProdutoPoco Delete(int chave)
        {
            Produto del = this.genrepo.Delete(chave);
            ProdutoPoco delPoco = this.ConvertTo(del);
            return delPoco;
        }

        public override ProdutoPoco Delete(ProdutoPoco poco)
        {
            Produto del = this.genrepo.Delete(ConvertTo(poco));
            ProdutoPoco delPoco = this.ConvertTo(del);
            return delPoco;
        }

        public override ProdutoPoco Edit(ProdutoPoco poco)
        {
            Produto editada = this.ConvertTo(poco);
            Produto alterada = this.genrepo.Update(editada);
            ProdutoPoco alteradaPoco = this.ConvertTo(alterada);
            return alteradaPoco;
        }

        public override ProdutoPoco Read(int chave)
        {
            Produto lida = this.genrepo.GetById(chave);
            ProdutoPoco lidaPoco = this.ConvertTo(lida);
            return lidaPoco;
        }
    }
}
