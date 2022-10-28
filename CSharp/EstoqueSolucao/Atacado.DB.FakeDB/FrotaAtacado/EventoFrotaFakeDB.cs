using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Atacado.Dominio.FrotaAtacado;

namespace Atacado.DB.FakeDB.FrotaAtacado
{
    public class EventoFrotaFakeDB
    {
        private static List<EventoFrota> eventoFrotas;
        public static List<EventoFrota> EventoFrotas
        {
            get
            {
                if (eventoFrotas == null)
                {
                    eventoFrotas = new List<EventoFrota>();
                    Carregar();
                }
                return eventoFrotas;
            }
        }
        private static void Carregar()
        {
            eventoFrotas.Add(new EventoFrota(1, true, DateTime.Now, "Bruno", new DateOnly(2000, 12, 30), new DateOnly(2001, 12, 30), 452.22, 497.85, "Transporte Passageiros"));
            eventoFrotas.Add(new EventoFrota(2, true, DateTime.Now, "Tiago", new DateOnly(1974, 2, 11), new DateOnly(1988, 2, 11), 551.26, 596.53, "Transporte Produtos Frios"));
            eventoFrotas.Add(new EventoFrota(3, true, DateTime.Now, "Marlon", new DateOnly(1963, 8, 22), new DateOnly(1968, 8, 22), 1208.52, 1305.60, "Transporte Produtos Secos"));
            eventoFrotas.Add(new EventoFrota(4, true, DateTime.Now, "Renato", new DateOnly(2006, 11, 8), new DateOnly(2009, 5, 2), 2564.78, 3459.86, "Transporte Produtos Fragil"));
            eventoFrotas.Add(new EventoFrota(5, true, DateTime.Now, "Rafael", new DateOnly(2016, 8, 4), new DateOnly(2017, 8, 4), 204.52, 231.54, "Transporte Volumosa e Grandes"));
        }
    }
}
