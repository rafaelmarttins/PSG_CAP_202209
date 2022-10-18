using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudoConsoleApp.Desafios
{
    public static class Desafio004v2
    {
        /// <summary>
        /// Desafio 004 - Crie um programa que leia um número e mostre o seu dobro, seu triplo e sua raiz quadrada.
        /// </summary>
        public static void Executar()
        {
            int valor;

            Console.Write("Informe o um número: ");
            if (Int32.TryParse(Console.ReadLine(), out valor) == false)
            {
                Console.WriteLine("Neste campo é aceito somente números.");
                return;
            }

            Console.WriteLine("O dobro é: {0}", (valor * 2));
            Console.WriteLine();
            Console.WriteLine("O Triplo é: {0}", (valor * 3));
            Console.WriteLine();
            Console.WriteLine("A Raiz Quadrada é: {0}", Math.Sqrt(Convert.ToDouble(valor)));
        }
    }
}
