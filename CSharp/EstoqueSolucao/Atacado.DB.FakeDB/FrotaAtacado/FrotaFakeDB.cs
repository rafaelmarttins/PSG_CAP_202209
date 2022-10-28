using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Atacado.Dominio.FrotaAtacado;

namespace Atacado.DB.FakeDB.FrotaAtacado
{
    public static class FrotaFakeDB
    {
        private static List<Frota> frotas;
        public static List<Frota> Frotas
        {
            get
            {
                if (frotas == null)
                {
                    frotas = new List<Frota>();
                    Carregar();
                }
                return frotas;
            }
        }
        private static void Carregar()
        {
            frotas.Add(new Frota(1, true, DateTime.Now, "Carregar Carga Frios", 10));
            frotas.Add(new Frota(2, true, DateTime.Now, "Carregar Carga Frigorífico", 22));
            frotas.Add(new Frota(3, true, DateTime.Now, "Carregar Carga Seca", 7));
            frotas.Add(new Frota(4, true, DateTime.Now, "Carregar Volumosas e Grandes", 14));
            frotas.Add(new Frota(5, true, DateTime.Now, "Carregar Carga Frágil", 3));
        }
    }
}
