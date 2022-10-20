using System;

using EstoqueApp.Model.Estoque;

namespace EstoqueApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Categoria cat = new Categoria(1, "Coca-Cola", true, DateTime.Now);
            cat.Imprimir();
        }
    }
}