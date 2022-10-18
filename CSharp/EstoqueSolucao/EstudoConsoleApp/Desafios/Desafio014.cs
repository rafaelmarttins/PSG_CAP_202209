using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudoConsoleApp.Desafios
{
    /// <summary>
    /// Desafio 014 – um professor quer armazenas o nome dos seus alunos para realizar algumas tarefas.
    /// Faça um programa que ajude ele, lendo o nome deles e escrevendo todos os nomes armazenados
    /// </summary>
    public static class Desafio014
    {
        public static void Executar()
        {
            List<string> nomes = new List<string>();

            bool sair = false;
            while (sair == false)
            {
                Console.WriteLine("Nomes na lista: {0}.", nomes.Count);
                bool check = true;
                while (check == true)
                {
                    Console.Write("Digite um nome de aluno:");
                    string nome = Console.ReadLine();
                    if (string.IsNullOrEmpty(nome.Trim()) == true)
                    {
                        Console.WriteLine("Nome é obrigatório.");
                        Console.WriteLine("Tente novamente.");
                    }
                    else
                    {
                        nomes.Add(nome);
                        check = false;
                    }
                }
                Console.WriteLine("Deseja sair <S/N>:");
                string teste = Console.ReadLine();
                if (teste.ToUpper() == "S")
                {
                    sair = true;
                }
                else
                {
                    Console.Clear();
                }
            }

            // IMPRIME TODOS OS NOMES DA LISTA
            Console.Clear();
            Console.WriteLine("Nomes da lista:");

            foreach (string nome in nomes)
            {
                Console.WriteLine("\t Nome: {0}", nome);
            }
        }
    }
}
