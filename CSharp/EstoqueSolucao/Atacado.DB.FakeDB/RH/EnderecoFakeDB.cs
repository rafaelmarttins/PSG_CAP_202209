using Atacado.Domino.RH;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atacado.DB.FakeDB.RH
{
    public class EnderecoFakeDB
    {
        private static List<Endereco> enderecos;

        public static List<Endereco> Enderecos
        {
            get
            {
                if (enderecos == null)
                {
                    enderecos = new List<Endereco>();
                    Carregar();
                }
                return enderecos;
            }
        }
        private static void Carregar()
        {
            enderecos.Add(new Endereco(1,"Rua 15", 676, "Ao lado do hospital", "Centro", "79560000", "Chapadão do Sul", "MS"));
            enderecos.Add(new Endereco(2, "Rua Brasilandia", 975, "Condominio di Palma", "Tiradentes", "79041050", "Campo Grande", "MS"));
            enderecos.Add(new Endereco(3, "Rua Barao", 452, "Condominio Dama", "Centro", "79051000", "Dourados", "MS"));
            enderecos.Add(new Endereco(4, "Avenida Afonso", 888, "Ao lado do Shopping", "Cachoeira", "79020000", "Cassilandia", "MS"));
            enderecos.Add(new Endereco(5, "Rua Bahia", 666, "Condominio Sárava", "Monte Castel", "79520000", "Fernandopolis", "SP"));
        }
    }
}
