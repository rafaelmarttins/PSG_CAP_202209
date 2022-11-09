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
    public class SubcategoriaServico : BaseServico<SubcategoriaPoco, Subcategoria>
    {
        private GenericRepository<Subcategoria> genrepo;

        public SubcategoriaServico() : base()
        {
            this.genrepo = new GenericRepository<Subcategoria>();
        }

        public override SubcategoriaPoco Add(SubcategoriaPoco poco)
        {
            Subcategoria nova = this.ConvertTo(poco);
            Subcategoria criada = this.genrepo.Insert(nova);
            SubcategoriaPoco criadaPoco = this.ConvertTo(criada);
            return criadaPoco;
        }

        public override List<SubcategoriaPoco> Browse()
        {
            return this.Browse(null);
        }

        public override List<SubcategoriaPoco> Browse(Expression<Func<Subcategoria, bool>> filtro = null)
        {
            List<SubcategoriaPoco> listPoco;
            IQueryable<Subcategoria> query;
            if (filtro == null)
            {
                query = this.genrepo.Browseable(null);
            }
            else
            {
                query = this.genrepo.Browseable(filtro);
            }
            listPoco = query.Select(sub =>
                    new SubcategoriaPoco()
                    {
                        Codigo = sub.Codigo,
                        Descricao = sub.Descricao,
                        Ativo = sub.Ativo,
                        DataInsert = sub.DataInsert,
                        CodigoCategoria = sub.CodigoCategoria
                    }
            )
            .ToList();
            return listPoco;
        }

        public override SubcategoriaPoco ConvertTo(Subcategoria dominio)
        {
            return new SubcategoriaPoco()
            {
                Codigo = dominio.Codigo,
                Descricao = dominio.Descricao,
                Ativo = dominio.Ativo,
                DataInsert = dominio.DataInsert,
                CodigoCategoria = dominio.CodigoCategoria
            };
        }

        public override Subcategoria ConvertTo(SubcategoriaPoco poco)
        {
            return new Subcategoria()
            {
                Codigo = poco.Codigo,
                Descricao = poco.Descricao,
                Ativo = poco.Ativo,
                DataInsert = poco.DataInsert,
                CodigoCategoria = poco.CodigoCategoria
            };
        }

        public override SubcategoriaPoco Delete(int chave)
        {
            Subcategoria del = this.genrepo.Delete(chave);
            SubcategoriaPoco delPoco = this.ConvertTo(del);
            return delPoco;
        }

        public override SubcategoriaPoco Delete(SubcategoriaPoco poco)
        {
            Subcategoria del = this.genrepo.Delete(ConvertTo(poco));
            SubcategoriaPoco delPoco = this.ConvertTo(del);
            return delPoco;
        }

        public override SubcategoriaPoco Edit(SubcategoriaPoco poco)
        {
            Subcategoria editada = this.ConvertTo(poco);
            Subcategoria alterada = this.genrepo.Update(editada);
            SubcategoriaPoco alteradaPoco = this.ConvertTo(alterada);
            return alteradaPoco;
        }

        public override SubcategoriaPoco Read(int chave)
        {
            Subcategoria lida = this.genrepo.GetById(chave);
            SubcategoriaPoco lidaPoco = this.ConvertTo(lida);
            return lidaPoco;
        }
    }
}
