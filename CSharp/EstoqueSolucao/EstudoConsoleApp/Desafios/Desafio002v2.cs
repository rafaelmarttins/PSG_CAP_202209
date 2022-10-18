using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudoConsoleApp.Desafios
{
    /// <summary>
    /// Desafio 002 – Crie um programa que leia o dia, o mês e ano de nascimento de uma pessoa e mostre uma mensagem 
    /// com a data formatada.
    /// </summary>
    public static class Desafio002v2
    {
        public static void Executar()
        {
            Console.Write("Digite o dia que você nasceu: ");
            int dia = int.Parse(Console.ReadLine());
            Console.Write("Agora o mês que você nasceu: ");
            int mes = int.Parse(Console.ReadLine());
            Console.Write("E o ano que você nasceu: ");
            int ano = int.Parse(Console.ReadLine());

            if (dia > 31 || dia < 1)
            {
                Console.Write("Favor digitar dia corretamente.");
            }
            else if (mes > 12 || mes < 1)
            {
                Console.Write("Favor digitar mês corretamente.");
            }
            else if (ano >= 2022 || ano < 1)
            {
                Console.Write("Favor digitar ano corretamente.");
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Você nasceu na data: " + dia + "/" + mes + "/" + ano);
            }
        }
    }
}
