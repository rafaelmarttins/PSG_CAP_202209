﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudoConsoleApp.Desafios
{
    public static class Desafio005
    {
        public static void CalcularMedia()
        {
            Console.Write("Informe a primeira nota: ");
            float nota1 = float.Parse(Console.ReadLine());
            Console.Write("Informe a segunda nota: ");
            float nota2 = float.Parse(Console.ReadLine());

            float media = (nota1 + nota2) / 2;
            Console.WriteLine();
            Console.WriteLine($"A média do aluno é: {media}");
        }
    }
}
