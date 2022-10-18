using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudoConsoleApp.Desafios
{
    /// <summary>
    /// Desafio 005 - Desenvolva um programa que leia as duas notas de um aluno, calcule e mostre a sua média.
    /// </summary>
    public static class Desafio005v2
    {
        public static void Executar()
        {
            double nota1, nota2;

            Console.Write("Informe a primeira nota: ");
            if (double.TryParse(Console.ReadLine(), out nota1) == false)
            {
                Console.WriteLine("Neste campo é aceito somente números.");
                return;
            }
            Console.Write("Informe a segunda nota: ");
            if (double.TryParse(Console.ReadLine(), out nota2) == false)
            {
                Console.WriteLine("Neste campo é aceito somente números.");
                return;
            }

            double media = (nota1 + nota2) / 2;
            Console.WriteLine();
            Console.WriteLine($"A média do aluno é: {media}");
        }
    }
}
