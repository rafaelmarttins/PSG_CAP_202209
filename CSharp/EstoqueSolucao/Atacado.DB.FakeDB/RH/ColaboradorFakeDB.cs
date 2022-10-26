using Atacado.Dominio.RH;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atacado.DB.FakeDB.RH
{
    public class ColaboradorFakeDB
    {
        private static List<Colaborador> colaboradores;

        public static List<Colaborador> Colaboradores
        {
            get
            {
                if (colaboradores == null)
                {
                    colaboradores = new List<Colaborador>();
                    Carregar();
                }
                return colaboradores;
            }
        }

        private static void Carregar()
        {
            colaboradores.Add(new Colaborador(1, "542", "123", "M", new DateTime(2020,12,22), "rafael@rafael", "456321", "1254", "458", true, "casado", 3, true, "TI", "Analista", 87521, "99633215", "545623852"));
            colaboradores.Add(new Colaborador(2, "123", "654", "F", new DateTime(1987,02,14), "aline@aline", "654123", "9547", "954", true, "divorciado", 0, true, "Finanças", "Contadora", 54263, "21452365", "753951852"));
            colaboradores.Add(new Colaborador(3, "452", "324", "M", new DateTime(1974,02,22), "bruno@bruno", "951753", "7852", "852", true, "solteiro", 1, true, "TI", "DBA", 65231, "99633215", "123654852"));
            colaboradores.Add(new Colaborador(4, "785", "752", "F", new DateTime(2000,12,30), "nathali@nathali", "951456", "6523", "421", true, "solteiro", 5, true, "TI", "Desenvolvedor", 145236, "32122775", "963147852"));
            colaboradores.Add(new Colaborador(5, "857", "458", "F", new DateTime(2000, 05, 11), "jessica@jessica", "1245", "8564", "985", true, "casada", 2, true, "TI", "Tester", 85475, "95684554", "111555666"));
        }
    }
}
