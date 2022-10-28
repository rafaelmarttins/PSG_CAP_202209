using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atacado.Poco.Estoque
{
    public class ProdutoPoco : BaseEstoque
    {
        private int codigoCategoria;

        private int codigoSubcategoria;
        public int CodigoSubcategoria { get => this.codigoSubcategoria; set => this.codigoSubcategoria = value; }
        public int CodigoCategoria { get => codigoCategoria; set => codigoCategoria = value; }

        public ProdutoPoco() : base()
        { }
    }
}
