using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace EstudoConsoleApp.Desafios
{
    /// <summary>
    /// Desafio 015 – o mesmo professor quer agora, além de exibir, ordenar a lista. Faça um programa
    /// que ajude ele, lendo o nome deles e escrevendo todos os nomes armazenados, de forma ordenada.
    /// </summary>
    public static class Desafio015
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
                Console.Write("Deseja sair <S/N>:");
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

            // Ordernação
            nomes.Sort(); 

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

