using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudoConsoleApp.Desafios
{
    /// <summary>
    /// Desafio 010 - Faça um programa que leia o preço de um produto, e mostre seu novo preço, com
    /// 5% de desconto.
    /// </summary>
    public static class Desafio010
    {
        public static void Executar()
        {
            Console.Write("Digite o preço do produto: ");
            double preco = double.Parse(Console.ReadLine());
            double desconto = 5.00;
            double resultado = preco - (preco * desconto) / 100;

            Console.WriteLine();
            Console.WriteLine($"Preço do produto sem desconto {preco}");
            Console.WriteLine();
            Console.Write($"Preço do produto com desconto {resultado}");
        }
    }
}
