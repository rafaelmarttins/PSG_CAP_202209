using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudoConsoleApp.Desafios
{
    /// <summary>
    /// Desafio 009 - Faça um programa que leia a largura e a altura de uma parede em metros, e calcule
    ///  a sua área e a quantidade de tinta necessária para pintá-la, sabendo que cada litro de tinta pinta
    ///  uma área de 2 metros quadrados.
    /// </summary>
    public static class Desafio009v2
    {
        public static void Executar()
        {
            double largura, altura, tinta;

            Console.Write("Digite a largura da parede em metros: ");
            if (double.TryParse(Console.ReadLine(), out largura) == false)
            {
                Console.WriteLine("Neste campo é aceito somente números.");
                return;
            }
            Console.Write("Digite a altura da parede em metros: ");
            if (double.TryParse(Console.ReadLine(), out altura) == false)
            {
                Console.WriteLine("Neste campo é aceito somente números.");
                return;
            }

            Console.WriteLine();
            Console.Write("É necessário {0}L de tinta para pintar a parede.", largura * altura / 2);
        }
    }
}
