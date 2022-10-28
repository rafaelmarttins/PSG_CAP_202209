using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Atacado.Dominio.FrotaAtacado;

namespace Atacado.DB.FakeDB.FrotaAtacado
{
    public static class CaminhaoFakeDB
    {
        private static List<Caminhao> caminhoes;
        public static List<Caminhao> Caminhoes
        {
            get
            {
                if (caminhoes == null)
                {
                    caminhoes = new List<Caminhao>();
                    Carregar();
                }
                return caminhoes;
            }
        }
        private static void Carregar()
        {
            caminhoes.Add(new Caminhao(1, true, DateTime.Now, "4F6B6AmFL50va2030", "Preto", "Volvo", "Fh 550", "MZC-4734", 562.000, 689.000, 620.000));
            caminhoes.Add(new Caminhao(2, true, DateTime.Now, "1uK8YPrYWlP6Y0267", "Laranja", "Scania", "Scania G 400", "NEL-8916", 890.000, 960.000, 920.000));
            caminhoes.Add(new Caminhao(3, true, DateTime.Now, "3fz893c9Aal5s5526", "Roxo", "Iveco", "IVECO Daily 30-130 City", "NEX-5032", 232.000, 366.000, 290.000));
            caminhoes.Add(new Caminhao(4, true, DateTime.Now, "8J6RAR9z820e66931", "Laranja", "Mercedes Benz", "Accelo", "GXF-0723", 996.000, 999.000, 985.000));
            caminhoes.Add(new Caminhao(5, true, DateTime.Now, "71S0blK1fx5V50064", "Cinza", "DAF", "DAF XF", "KCY-7590", 555.666, 666.444, 452.236));
        }
    }
}
