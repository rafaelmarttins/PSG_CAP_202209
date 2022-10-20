using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudoConsoleApp.Desafios
{
    /// <summary>
    /// Desafio 020 - Desenvolva um método que permita a entrada do nome do usuário e exiba
    /// Imprima a frase “Olá meu nome é: {nome recebido}”.
    /// O nome com todas as letras maiúsculas e minúsculas.
    /// Quantas letras ao todo (sem considerar espaços).
    /// Quantas letras tem o primeiro nome.
    /// </summary>
    public static class Desafio020
    {
        public static void Executar()
        {

            Console.Write("Favor digitar seu primeiro nome: ");
            string nome = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine("Olá meu nome é: {0}!", nome);
            Console.WriteLine();
            Console.WriteLine("Meu nome em maiúsculas: {0}.", nome.ToUpper());
            Console.WriteLine();
            Console.WriteLine("Meu nome em minúsculas: {0}.", nome.ToLower());
            Console.WriteLine();
            Console.WriteLine("Meu nome tem {0} letras.", nome.Replace(" ", "").Trim().Length);
            Console.WriteLine();
            Console.WriteLine("Meu nome primeiro nome tem {0} letras.", nome.IndexOf(" "));
        }
    }
}
