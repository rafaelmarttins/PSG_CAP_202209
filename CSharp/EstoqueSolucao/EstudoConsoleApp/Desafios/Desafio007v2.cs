using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudoConsoleApp.Desafios
{
    /// <summary>
    /// Desafio 007 - Faça um programa que leia um número inteiro e mostre na sua tela a sua tabuada.
    /// </summary>
    public static class Desafio007v2
    {
        public static void Executar()
        {
            int valor;

            Console.Write("Digite a tabuada desejada: ");
            if (Int32.TryParse(Console.ReadLine(), out valor) == false)
            {
                Console.WriteLine("Neste campo é aceito somente números.");
                return;
            }
            for (int x = 1; x <= 10; x++)
            {
                Console.WriteLine(valor + " * " + x + " = " + valor * x);
            }
        }
    }
}
