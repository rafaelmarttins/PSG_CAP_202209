using Atacado.Dominio.RH;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atacado.DB.FakeDB.RH
{
    public static class PrestadorFakeDB
    {
        private static List<Prestador> prestadores;

        public static List<Prestador> Prestadores
        {
            get
            {
                if (prestadores == null)
                {
                    prestadores = new List<Prestador>();
                    Carregar();
                }
                return prestadores;
            }
        }
        private static void Carregar()
        {
            prestadores.Add(new Prestador(1, "Luiz", "LuizDaTI", "LuizECia", "524", "741", new DateTime(1974, 06, 11), "luiz@luiz", new DateOnly(2020, 06, 11), new DateOnly(2022, 06, 11)));
            prestadores.Add(new Prestador(2, "Pedro", "PedroDoCarro", "PedroECia", "528", "999", new DateTime(1988, 11, 30), "pedro@pedro", new DateOnly(2011, 08, 14), new DateOnly(2012, 08, 20)));
            prestadores.Add(new Prestador(3, "Tiago", "TiagoDaBike", "TiagoECia", "956", "235", new DateTime(1955, 01, 03), "tiago@tiago", new DateOnly(2018, 12, 30), new DateOnly(2019, 12, 30)));
            prestadores.Add(new Prestador(4, "Marlon", "MarlonDaRua", "MarlonECia", "222", "444", new DateTime(2022, 09, 30), "marlon@marlon", new DateOnly(2022, 09, 30), new DateOnly(2024, 09, 30)));
            prestadores.Add(new Prestador(5, "Bruno", "BrunoDaBoate", "BrunoECia", "999", "745", new DateTime(2006, 12, 10), "bruno@bruno", new DateOnly(2007, 06, 31), new DateOnly(2008, 06, 31)));
        }
    }
}
