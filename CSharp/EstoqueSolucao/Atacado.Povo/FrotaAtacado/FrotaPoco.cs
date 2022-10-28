using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atacado.Poco.FrotaAtacado
{
    public class FrotaPoco : BaseCampos
    {
        private string finalidade;

        private int veiculos;

        public string Finalidade { get => finalidade; set => finalidade = value; }
        public int Veiculos { get => veiculos; set => veiculos = value; }

        public FrotaPoco() : base()
        { }
    }
}
