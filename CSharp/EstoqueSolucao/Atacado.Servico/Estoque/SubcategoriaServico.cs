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
    public class SubcategoriaServico : GenericService<Subcategoria, SubcategoriaPoco>
    {
        public override List<SubcategoriaPoco> Consultar(Expression<Func<Subcategoria, bool>>? predicate = null)
        {
            IQueryable<Subcategoria> query;
            if (predicate == null)
            {
                query = this.genrepo.Browseable(null);
            }
            else
            {
                query = this.genrepo.Browseable(predicate);
            }
            List<SubcategoriaPoco> listaPoco = query.Select(sub =>
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
            return listaPoco;
        }
    }
}
