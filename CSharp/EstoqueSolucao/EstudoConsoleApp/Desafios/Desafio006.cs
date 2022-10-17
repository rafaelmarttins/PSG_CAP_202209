using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudoConsoleApp.Desafios
{
    /// <summary>
    /// Desafio 006 - Escreva um programa que leia um valor em metros e o exiba convertido em
    /// centímetros e milímetros.
    /// </summary>
    public static class Desafio006
    {
        public static void ConversorComprimento()
        {
            Console.Write("Informe a quantidade de metros: ");
            float metros = float.Parse(Console.ReadLine());
            float centrimentros = metros * 100;
            float milimetros = metros * 1000;
            Console.WriteLine();
            Console.WriteLine($"O metro convertido em Centímetros é: {centrimentros}");
            Console.WriteLine($"E em Milímetros é: {milimetros}");
        }
    }
}
