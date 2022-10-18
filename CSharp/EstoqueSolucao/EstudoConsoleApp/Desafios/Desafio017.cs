using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;

namespace EstudoConsoleApp.Desafios
{
    /// <summary>
    /// Desafio 017 – o mesmo professor quer sortear a ordem de apresentação de trabalhos dos alunos.
    /// Faça um programa que leia o nome dos quatro alunos e a ordem sorteada.
    /// </summary>
    public static class Desafio017
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

            List<int> pos = new List<int>();
            int indice = 0;
            while (indice < nomes.Count)
            {
                int posicao = rnd.Next(nomes.Count);
                if (pos.Count == 0)
                {
                    pos.Add(posicao);
                    indice++;
                }
                else
                {
                    if (pos.Contains(posicao) == false)
                    {
                        pos.Add(posicao);
                        indice++;
                    }
                }
            }

            // Imprimindo lista sorteada.
            Console.WriteLine("Imprindo lista sorteada.");
            for (int i = 0; i < pos.Count; i++)
            {
                int num = pos[i];
                Console.WriteLine("\t Nome: {0}", nomes[pos[i]]);
            }
        }
    }
}

