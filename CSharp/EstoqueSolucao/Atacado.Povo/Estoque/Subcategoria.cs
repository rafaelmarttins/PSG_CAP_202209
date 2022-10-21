﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atacado.Poco.Estoque
{
    public class Subcategoria : BaseEstoque
    {
        private int codigoCategoria;
        public int CodigoCategoria { get => this.codigoCategoria; set => this.codigoCategoria = value; }

        public Subcategoria(int codigoCategoria) : base()
        { }

        public Subcategoria(int codigo, string descricao, bool ativo, DateTime dataInclusao, int codigoCategoria)
             : base(codigo, descricao, ativo, dataInclusao)
        {
            this.codigoCategoria = codigoCategoria;
        }
    }
}
