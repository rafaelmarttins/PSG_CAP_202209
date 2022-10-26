using Atacado.Dominio.Estoque;
using Atacado.Dominio.RH;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atacado.DB.FakeDB.RH
{
    public static class ParceiroFakeDB
    {
        private static List<Parceiro> parceiros;

        public static List<Parceiro> Parceiros
        {
            get
            {
                if (parceiros == null)
                {
                    parceiros = new List<Parceiro>();
                    Carregar();
                }
                return parceiros;
            }
        }
        private static void Carregar()
        {
            parceiros.Add(new Parceiro(1, "Joao", "JoaoDoBar", "JoaoeCia", "256325", "852", new DateTime(2020, 12, 22), "joao@joao", 85, "TI", 5421));
            parceiros.Add(new Parceiro(2, "Rafael", "RafaelDoBar", "RafaeleCia", "214523", "963", new DateTime(2020, 03, 14), "rafael@rafael", 99, "TI", 9651));
            parceiros.Add(new Parceiro(3, "Akira", "AkiraDoBar", "AkiraeCia", "222333", "888", new DateTime(1974, 06, 11), "akira@akira", 74, "TI", 2563));
            parceiros.Add(new Parceiro(4, "Bruno", "BrunoDoBar", "BrunoeCia", "123645", "745", new DateTime(1985, 08, 19), "bruno@bruno", 55, "TI", 8852));
            parceiros.Add(new Parceiro(5, "Marlon", "MarlonDoBar", "MarloneCia", "785652", "415", new DateTime(1965, 11, 28), "marlon@marlon", 85, "TI", 5421));
        }
    }
}
