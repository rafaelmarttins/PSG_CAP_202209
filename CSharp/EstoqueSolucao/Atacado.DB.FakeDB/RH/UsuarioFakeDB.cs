using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Atacado.Dominio.Estoque;
using Atacado.Dominio.RH;


namespace Atacado.DB.FakeDB.RH
{
    public static class UsuarioFakeDB
    {
        private static List<Usuario> usuarios;

        public static List<Usuario> Usuarios
        {
            get
            {
                if (usuarios == null)
                {
                    usuarios = new List<Usuario>();
                    Carregar();
                }
                return usuarios;
            }
        }

        private static void Carregar()
        {
            usuarios.Add(new Usuario(1, "rafael.martins", "992508", "Admin"));
            usuarios.Add(new Usuario(2, "aline.souza", "258963", "Client"));
            usuarios.Add(new Usuario(3, "pedro.soares", "741258", "Client"));
            usuarios.Add(new Usuario(4, "joao.barreto", "852369", "Admin"));
            usuarios.Add(new Usuario(5, "tiago.silva", "852753", "Admin"));
        }
    }
}
