using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Atacado.Dominio.FrotaAtacado;

namespace Atacado.DB.FakeDB.FrotaAtacado
{
    public static class MotocicletaFakeDB
    {
        private static List<Motocicleta> motocicletas;
        public static List<Motocicleta> Motocicletas
        {
            get
            {
                if (motocicletas == null)
                {
                    motocicletas = new List<Motocicleta>();
                    Carregar();
                }
                return motocicletas;
            }
        }
        private static void Carregar()
        {
            motocicletas.Add(new Motocicleta(1, true, DateTime.Now, "3l0bMAzNu9pAC7554", "Preto", "Honda", "Biz 125", "MVR-4696", 180, 105, 285));
            motocicletas.Add(new Motocicleta(2, true, DateTime.Now, "61XMAA2JmM9kd7362", "Branca", "Honda", "Biz 125", "JBF-9224", 180, 105, 285));
            motocicletas.Add(new Motocicleta(3, true, DateTime.Now, "1MKNUa4gS0TxS8866", "Azul", "Honda", "CG 160 Titan", "HTR-6995", 200, 121, 321));
            motocicletas.Add(new Motocicleta(4, true, DateTime.Now, "8pA9uhPbJ9Rzn7635", "Branca", "Honda", "Pop 110i", "IAD-5778", 120, 87, 207));
            motocicletas.Add(new Motocicleta(5, true, DateTime.Now, "5YA0m1Pf0j91M6968", "Vermelha", "Honda", "CB 1000R Black Edition", "MNF-7635", 280, 204, 484));
        }
    }
}
