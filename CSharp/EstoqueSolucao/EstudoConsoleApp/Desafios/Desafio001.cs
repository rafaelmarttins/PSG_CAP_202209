using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace EstudoConsoleApp.Desafios
{
    public static class Desafio001
    {
        public static void BoasVindas()
        {
            Console.Write("Favor digitar seu primeiro nome: ");
            string nome = Console.ReadLine();

            if (string.IsNullOrEmpty(nome)) // Poderia usar "" vazia.
            {
                Console.WriteLine("Campo Obrigatório Digite seu Nome.");
            }
            else if (!Regex.IsMatch(nome, @"^[a-zA-Z]+$")) // Condição para aceitar apenas string
            {
                Console.WriteLine();
                Console.WriteLine("Seu nome não pode conter números,caracteres especiais ou espaços.");
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine($"Seja Bem Vindo {nome}!");
            }
        }
    }
}
