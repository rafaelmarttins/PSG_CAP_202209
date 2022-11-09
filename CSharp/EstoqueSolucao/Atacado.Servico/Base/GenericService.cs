﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Atacado.DB.EF.Database;
using Atacado.Poco.Estoque;
using Atacado.Repositorio.Base;

namespace Atacado.Servico.Base
{
    public class GenericService<TDominio, TPoco> : IGenericService<TDominio, TPoco>
        where TDominio : class
        where TPoco : class
    {

        private GenericRepository<TDominio> genrepo;

        public GenericService()
        {
            this.genrepo = new GenericRepository<TDominio>();
        }

        public List<TPoco> Listar()
        {
            return this.Consultar(null).ToList<TPoco>();
        }

        public virtual IQueryable<TPoco> Consultar(Expression<Func<TDominio, bool>> predicate = null)
        {
            throw new NotImplementedException();
        }

        public TPoco PesquisarPelaChave(object chave)
        {
            TDominio lida = this.genrepo.GetById(chave);
            TPoco lidaPoco = this.ConverterPara(lida);
            return lidaPoco;
        }

        public TPoco Inserir(TPoco obj)
        {
            TDominio nova = this.ConverterPara(obj);
            TDominio criada = this.genrepo.Insert(nova);
            TPoco criadaPoco = this.ConverterPara(criada);
            return criadaPoco;
        }

        public TPoco Alterar(TPoco obj)
        {
            TDominio editada = this.ConverterPara(obj);
            TDominio alterada = this.genrepo.Update(editada);
            TPoco alteradaPoco = this.ConverterPara(alterada);
            return alteradaPoco;
        }

        public TPoco Excluir(object chave)
        {
            TDominio del = this.genrepo.Delete(chave);
            TPoco delPoco = this.ConverterPara(del);
            return delPoco;
        }

        public virtual TDominio ConverterPara(TPoco obj)
        {
            throw new NotImplementedException();
        }

        public virtual TPoco ConverterPara(TDominio obj)
        {
            throw new NotImplementedException();
        }
    }
}
