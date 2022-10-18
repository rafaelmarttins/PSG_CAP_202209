using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace EstudoConsoleApp.Desafios
{
        /// <summary>
        /// Desafio 001 - Crie um programa que leia o nome de uma pessoa e mostre uma mensagem de 
        /// boas-vindas de acordo com o valor digitado
        /// </summary>
        public static class Desafio001v2
        {
            public static void Executar()
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
