using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudoConsoleApp.Desafios
{
    /// <summary>
    /// Desafio 006 - Escreva um programa que leia um valor em metros e o exiba convertido em
    /// centímetros e milímetros.
    /// </summary>
    public static class Desafio006v2
    {
        public static void Executar()
        {
            double metros, centrimentros, milimetros;

            Console.Write("Informe a quantidade de metros: ");
            if (double.TryParse(Console.ReadLine(), out metros) == false)
            {
                Console.WriteLine("Neste campo é aceito somente números.");
                return;
            }

            Console.WriteLine("O metro convertido em Centímetros é: {0}", metros * 100);
            Console.WriteLine("E em Milímetros é: {0}", metros * 1000);
        }
    }
}
 