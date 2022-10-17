using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace EstudoConsoleApp.Desafios
{
    /// <summary>
    /// Desafio 003 – Crie um programa que leia dos números e tente mostrar a soma entre eles.
    /// </summary>
    public static class Desafio003
    {
        public static void Somar()
        {
            Console.Write("Informe o Primeiro número: ");
            float valor1 = float.Parse(Console.ReadLine());
            Console.Write("Informe o Segundo número: ");
            float valor2 = float.Parse(Console.ReadLine());

            float resultado = valor1 + valor2;

            bool check = Regex.IsMatch(resultado.ToString(), "^[0-9]+$");

            if (!check)
            {
                Console.WriteLine();
                throw new FormatException("Este campo pode existir somente números.");
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine($"A soma entre os dois números é: {resultado}");
            }
        }
    }
}
