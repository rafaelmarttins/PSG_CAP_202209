﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudoConsoleApp.Desafios
{
    /// <summary>
    /// Desafio 008 - Crie um programa que leia o quanto uma pessoa tem na carteira e mostre quantos dólares ela pode 
    /// comprar.
    ///  Considere US$ 1,00 = R$ 5,00
    /// </summary>
    public static class Desafio008v2
    {
        public static void Executar()
        {
            double real, dolar;
            Console.Write("Digite quanto dinheiro você tem: ");
            if (double.TryParse(Console.ReadLine(), out real) == false)
            {
                Console.WriteLine("Neste campo é aceito somente números.");
                return;
            }
            Console.WriteLine();
            Console.Write("Com {0} reais você pode comprar {1} dolars.", real, real / 5.00);
        }
    }
}
