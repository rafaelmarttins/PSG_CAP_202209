using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudoConsoleApp.Desafios
{
    public static class Desafio007
    {
        public static void Tabuada()
        {
            Console.Write("Digite a tabuada desejada: ");
            int valor = int.Parse(Console.ReadLine());
            for (int x = 1; x <= 10; x++)
            {
                Console.WriteLine(valor + " * " + x + " = " + valor * x);
            }
        }
    }
}
