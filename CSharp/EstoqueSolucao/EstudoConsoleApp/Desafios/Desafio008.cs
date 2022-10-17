using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudoConsoleApp.Desafios
{
    /// <summary>
    /// Desafio 008 - Crie um programa que leia o quanto uma pessoa tem na carteira e mostre quantos
    //  dólares ela pode comprar.
    //  Considere US$ 1,00 = R$ 5,00
    /// </summary>
    public static class Desafio008
    {
        public static void Dolar()
        {
            Console.Write("Digite quanto dinheiro você tem: ");
            double real = int.Parse(Console.ReadLine());
            double dolar = real / 5.00;
            Console.WriteLine();
            Console.Write($"Com {real} reais você pode comprar {dolar} dolars.");
        }
    }
}
