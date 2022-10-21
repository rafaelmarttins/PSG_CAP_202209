using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atacado.Poco.RH
{
    public class ParceiroPoco : BaseJuridica
    {
        private double desempenho;

        private string setor;

        private double comissao;

        public double Desempenho { get => desempenho; set => desempenho = value; }
        public string Setor { get => setor; set => setor = value; }
        public double Comissao { get => comissao; set => comissao = value; }

        public ParceiroPoco() : base()
        { }
    }
}
