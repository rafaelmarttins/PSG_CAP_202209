using Atacado.Dominio.FrotaAtacado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atacado.DB.FakeDB.FrotaAtacado
{
    public static class CarroFakeDB
    {
        private static List<Carro> carros;
        public static List<Carro> Carros
        {
            get
            {
                if (carros == null)
                {
                    carros = new List<Carro>();
                    Carregar();
                }
                return carros;
            }
        }
        private static void Carregar()
        {
            carros.Add(new Carro(1, true, DateTime.Now, "2gAYgvfk1j34f1019", "Preto", "Volkswagen", "Gol", "LVI-8867", 30.000, 24.000, 54.000, 5));
            carros.Add(new Carro(2, true, DateTime.Now, "3l7263ytcP79e0692", "Branca", "Fiat", "Uno", "HPQ-7895", 920, 820, 1.720, 5));
            carros.Add(new Carro(3, true, DateTime.Now, "3W3Z2yLmDj4507919", "Vermelha", "Volkswagen", "Saveiro", "KFO-0485", 1.300, 1.120, 2.420, 3));
            carros.Add(new Carro(4, true, DateTime.Now, "640nAApDf7A507738", "Roxa", "Fiat", "Fastback", "MTC-6212", 3.555, 2.555, 6110, 7));
            carros.Add(new Carro(5, true, DateTime.Now, "6CJE4mfAd3a7C1508", "Chumbo", "Chevrolet", "Onix", "MLY-3782", 2.900, 2.300, 5.200, 5));
        }
    }
}
