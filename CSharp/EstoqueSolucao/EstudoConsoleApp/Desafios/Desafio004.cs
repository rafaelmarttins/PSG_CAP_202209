using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudoConsoleApp.Desafios
{
    public static class Desafio004
    {
        public static void DobroTriploRaiz()
        {
            Console.Write("Informe o um número: ");
            int valor = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("O dobro é: {0}", (valor * 2));
            Console.WriteLine();
            Console.WriteLine("O Triplo é: {0}", (valor * 3));
            Console.WriteLine();
            Console.WriteLine("A Raiz Quadrada é: {0}", (float)Math.Sqrt(valor));
        }
    }
}
