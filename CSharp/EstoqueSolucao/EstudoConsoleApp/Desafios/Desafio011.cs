using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudoConsoleApp.Desafios
{
    /// <summary>
    /// Desafio 011 – Faça um programa que leia o salário de um funcionário, e mostre seu novo salário,
    /// com 15% de aumento.
    /// </summary>
    public static class Desafio011
    {
        public static void Executar()
        {
            Console.Write("Favor digitar seu salário: ");
            double salario = double.Parse(Console.ReadLine());
            double aumento = 0.15;
            double novoSalario = salario * aumento + salario;

            Console.WriteLine();
            Console.WriteLine($"Salário com sem aumento {salario}");
            Console.WriteLine();
            Console.Write($"Salário com novo aumento {novoSalario}");
        }
    }
}
