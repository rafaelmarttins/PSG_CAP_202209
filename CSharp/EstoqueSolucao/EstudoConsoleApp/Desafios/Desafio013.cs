using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudoConsoleApp.Desafios
{
    /// <summary>
    /// Desafio 013 – Escreva um programa que pergunte a quantidade de km percorridos por um carro
    /// alugado, e a quantidade de dias pelos quais ele foi alugado.Calcule o preço a pagar, sabendo
    /// que o carro custa R$ 60,00 por dia e R$ 0,15 por km rodado.
    /// </summary>
    public static class Desafio013
    {
        public static void Executar()
        {
            Console.Write("Favor digitar quantos Km foi percorridos: ");
            double kmPercorrido = double.Parse(Console.ReadLine());
            Console.Write("Favor digitar quantos dias o carro foi alugado: ");
            double diasAlugado = double.Parse(Console.ReadLine());
            double ValorAPagar = kmPercorrido * 0.15 + diasAlugado * 60;

            Console.WriteLine();
            Console.Write($"Preço a pagar pelo uso do carro é {ValorAPagar}.");
        }
    }
}
