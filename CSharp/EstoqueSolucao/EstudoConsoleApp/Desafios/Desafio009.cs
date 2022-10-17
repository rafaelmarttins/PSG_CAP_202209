using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudoConsoleApp.Desafios
{
    public static class Desafio009
    {
        public static void QtdTinta()
        {
            Console.Write("Digite a largura da parede em metros: ");
            float largura = float.Parse(Console.ReadLine());
            Console.Write("Digite a altura da parede em metros: ");
            float altura = float.Parse(Console.ReadLine());
            float tinta = largura * altura / 2;
            Console.WriteLine();
            Console.Write($"É necessário {tinta}L de tinta para pintar a parede.");
        }
    }
}
