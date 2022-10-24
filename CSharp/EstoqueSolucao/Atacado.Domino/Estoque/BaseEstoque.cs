﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atacado.Dominio.Estoque
{
    public abstract class BaseEstoque
    {
        protected int codigo;

        protected string descricao;

        protected bool ativo;

        protected DateTime dataInclusao;

        public int Codigo { get => this.codigo; set => this.codigo = value; }
        public string Descricao { get => this.descricao; set => this.descricao = value; }
        public bool Ativo { get => this.ativo; set => this.ativo = value; }
        public DateTime DataInclusao { get => this.dataInclusao; set => this.dataInclusao = value; }

        public BaseEstoque()
        { }

        public BaseEstoque(int codigo, string descricao, bool ativo, DateTime dataInclusao)
        {
            this.codigo = codigo;
            this.descricao = descricao;
            this.ativo = ativo;
            this.dataInclusao = dataInclusao;
        }
    }
}
