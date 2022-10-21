﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atacado.Poco.Estoque
{
    public class Categoria : BaseEstoque
    {
        public Categoria() : base()
        { }

        public Categoria(int codigo, string descricao, bool ativo, DateTime dataInclusao)
            : base(codigo, descricao, ativo, dataInclusao)
        { }
    }
}
