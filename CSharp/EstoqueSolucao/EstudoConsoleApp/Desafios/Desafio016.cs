using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudoConsoleApp.Desafios
{
    /// <summary>
    /// Desafio 016 – o mesmo professor quer sortear um dos seus alunos para apagar o quadro. Faça um
    /// programa que ajude ele, lendo o nome deles e escrevendo o nome do escolhido.
    /// </summary>
    public static class Desafio016
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

            // Sorteio
            Random rnd = new Random();
            int posicao = rnd.Next(nomes.Count);
            Console.WriteLine("Aluno escolhido para apagar o quadro é: {0}", nomes[posicao]);
        }
    }
}
