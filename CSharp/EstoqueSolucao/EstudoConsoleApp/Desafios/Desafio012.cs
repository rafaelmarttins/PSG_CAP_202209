using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudoConsoleApp.Desafios
{
    /// <summary>
    /// Desafio 012 – escreva um programa que converta uma temperatura digitada em graus celsius
    /// para fahrenheit.
    /// </summary>
    public static class Desafio012
    {
        public static void Executar()
        {
            Console.Write("Favor digitar uma temperatura em Celsius: ");
            double celsius = double.Parse(Console.ReadLine());
            double conversao = (9 * celsius / 5) + 32;

            Console.WriteLine();
            Console.WriteLine($"Temperatura em Celsius {celsius}");
            Console.WriteLine();
            Console.WriteLine($"Temperatura convertida em Fahrenheit {conversao}");
        }

    }
}
