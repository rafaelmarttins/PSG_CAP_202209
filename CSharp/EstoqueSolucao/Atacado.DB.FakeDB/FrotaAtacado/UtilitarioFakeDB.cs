using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Atacado.Dominio.FrotaAtacado;

namespace Atacado.DB.FakeDB.FrotaAtacado
{
    public static class UtilitarioFakeDB
    {
        private static List<Utilitario> utilitarios;
        public static List<Utilitario> Utilitarios
        {
            get
            {
                if (utilitarios == null)
                {
                    utilitarios = new List<Utilitario>();
                    Carregar();
                }
                return utilitarios;
            }
        }
        private static void Carregar()
        {
            utilitarios.Add(new Utilitario(1, true, DateTime.Now, "16n5b75LAwZ2R6905", "Preto", "Toyota", "Hilux", "NEQ-2323", 4.000, 2.085, 6085));
            utilitarios.Add(new Utilitario(2, true, DateTime.Now, "1BA8dcAK9nwAX7402", "Branca", "Chevrolet", "S10", "IAH-2648", 2.810, 1.810, 4.620)); ;
            utilitarios.Add(new Utilitario(3, true, DateTime.Now, "4S12KFT3dAAH56223", "Vermelha", "Ford", "Ranger", "IFR-6119", 5.370, 3.270, 8.640));
            utilitarios.Add(new Utilitario(4, true, DateTime.Now, "5YMAYfpRnb15m7622", "Roxa", "Mitsubishi", "L200 Triton", "KKK-2183", 2.940, 1.940, 4.880));
            utilitarios.Add(new Utilitario(5, true, DateTime.Now, "41t18A58ykAg90643", "Chumbo", "Nissan", "Frontier", "MUB-3646", 2.000, 1.985, 3.985));
        }
    }
}
