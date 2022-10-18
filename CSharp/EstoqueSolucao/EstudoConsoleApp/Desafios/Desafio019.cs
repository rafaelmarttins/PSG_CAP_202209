using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudoConsoleApp.Desafios
{
    /// <summary>
    /// Desafio 019 - Desenvolva um método que solicite a entrada de um número e calcule se o número é par ou ímpar.
    /// </summary>
    public static class Desafio019
    {
        public static void Executar()
        {
            Console.Write("Digite um número: ");
            int num = int.Parse(Console.ReadLine());

            if (num % 2 == 0)
            {
                Console.WriteLine("O número {0} é par.", num);
            }
            else
            {
                Console.WriteLine("O número {0} é impar.", num);
            }
        }

    }
}
