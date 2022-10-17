using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudoConsoleApp.Desafios
{
    public static class Desafio010
    {
        public static void Desconto()
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
