﻿using System;
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
    public class ProdutoServico : GenericService<Produto, ProdutoPoco>
    {
        public override ProdutoPoco ConverterPara(Produto obj)
        {
            return new ProdutoPoco()
            {
                Codigo = obj.Codigo,
                Descricao = obj.Descricao,
                Ativo = obj.Ativo,
                DataInsert = obj.DataInsert,
                CodigoCategoria = obj.CodigoCategoria,
                CodigoSubcategoria = obj.CodigoSubcategoria
            };
        }

        public override Produto ConverterPara(ProdutoPoco obj)
        {
            return new Produto()
            {
                Codigo = obj.Codigo,
                Descricao = obj.Descricao,
                Ativo = obj.Ativo,
                DataInsert = obj.DataInsert,
                CodigoCategoria = obj.CodigoCategoria,
                CodigoSubcategoria = obj.CodigoSubcategoria
            };
        }

        public override List<ProdutoPoco> ConverterPara(IQueryable<Produto> query)
        {
            return query.Select(pro =>
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
        }

        public override List<ProdutoPoco> Consultar(Expression<Func<Produto, bool>>? predicate = null)
        {
            IQueryable<Produto> query;
            if (predicate == null)
            {
                query = this.genrepo.Browseable(null);
            }
            else
            {
                query = this.genrepo.Browseable(predicate);
            }
            List<ProdutoPoco> listaPoco = query.Select(pro =>
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
            return listaPoco;
        }

        public override List<ProdutoPoco> Listar(int? take = null, int? skip = null)
        {
            IQueryable<Produto> query;
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
    }
}
