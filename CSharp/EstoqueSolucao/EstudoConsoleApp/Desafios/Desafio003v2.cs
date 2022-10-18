using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudoConsoleApp.Desafios
{
    /// <summary>
    /// Desafio 003 – Crie um programa que leia dos números e tente mostrar a soma entre eles.
    /// </summary>
    public static class Desafio003v2
    {
        public static void Executar()
        {
            int valor1, valor2;

            Console.Write("Informe o primeiro número: ");
            if (Int32.TryParse(Console.ReadLine(), out valor1) == false)
            {
                Console.WriteLine("Neste campo é aceito somente números.");
                return;
            }

            Console.Write("Informe o Segundo número: ");
            if (Int32.TryParse(Console.ReadLine(), out valor2) == false)
            {
                Console.WriteLine("Neste campo é aceito somente números.");
                return;
            }

            int resultado = valor1 + valor2;

            Console.WriteLine();
            Console.WriteLine($"A soma entre os dois números é: {resultado}");
        }
    }
}
