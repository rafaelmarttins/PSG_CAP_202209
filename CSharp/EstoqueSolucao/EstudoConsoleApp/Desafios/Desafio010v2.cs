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
    public static class Desafio010v2
    {
        public static void Executar()
        {
            double preco, desconto = 5.00, resultado;
            Console.Write("Digite o preço do produto: ");
            if (double.TryParse(Console.ReadLine(), out preco) == false)
            {
                Console.WriteLine("Neste campo é aceito somente números.");
                return;
            }

            Console.WriteLine($"Preço do produto sem desconto {preco}");
            Console.WriteLine();
            Console.Write("Preço do produto com desconto {0}", preco -(preco * desconto) / 100);
        }
    }
}
