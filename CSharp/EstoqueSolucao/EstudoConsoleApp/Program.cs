using System;
using System.Security.Cryptography.X509Certificates;
using EstudoConsoleApp.Aulas;
using EstudoConsoleApp.Desafios;

namespace EstudoConsoleApp;

public class Program
{
    public static void Main(string[] args)
    {
        // Exemplos de Comparações lógicas e Operações Matemáticas.
        
        //ExecutarExemplo001();
        //ExecutarExemplo002();
        //ExecutarExemplo003();
        //ExecutarExemplo004();
        //ExecutarExemplo005();

        // LISTA DESAFIOS SEM VALIDAÇÕES

        //Desafio001.Executar();
        //Desafio002.Executar();
        //Desafio003.Executar();
        //Desafio004.Executar();
        //Desafio005.Executar();
        //Desafio006.Executar();
        //Desafio007.Executar();
        //Desafio008.Executar();
        //Desafio009.Executar();
        //Desafio010.Executar();

        // LISTA DESAFIOS COM VALIDAÇÕES

        //Desafio001v2.Executar();
        //Desafio002v2.Executar();
        //Desafio003v2.Executar();
        //Desafio004v2.Executar();
        //Desafio005v2.Executar();
        //Desafio006v2.Executar();
        //Desafio007v2.Executar();
        //Desafio008v2.Executar();
        //Desafio009v2.Executar();
        //Desafio010v2.Executar();

    }

    public static void ExecutarExemplo001()
    {
        Console.WriteLine("Operações Matématicas");
        Console.WriteLine();
        Console.Write("Favor informar o primeiro número: ");
        int n1 = int.Parse(Console.ReadLine());
        Console.Write("Favor informar o segundo número: ");
        int n2 = int.Parse(Console.ReadLine());
        Console.WriteLine();
        Console.WriteLine("Somar: {0}", OperacoesMatematicas.Somar(n1, n2));
        Console.WriteLine();
        Console.WriteLine("Subtrair: {0}", OperacoesMatematicas.Subtrair(n1, n2));
        Console.WriteLine();
        Console.WriteLine("Multiplicar: {0}", OperacoesMatematicas.Multiplicar(n1, n2));
        Console.WriteLine();
        Console.WriteLine("Dividir: {0}", OperacoesMatematicas.Dividir(n1, n2));
        Console.ReadLine();
    }

    public static void ExecutarExemplo002()
    {
        Console.WriteLine("Comparações Lógicas");
        Console.WriteLine();
        Console.Write("Favor informar o primeiro número: ");
        int n1 = int.Parse(Console.ReadLine());
        Console.Write("Favor informar o segundo número: ");
        int n2 = int.Parse(Console.ReadLine());
        Console.WriteLine();
        ComparacoesLogicas.MaiorQue(n1, n2);
        Console.WriteLine();
        ComparacoesLogicas.MenorQue(n1, n2);
        Console.WriteLine();
        Console.ReadLine();
    }

    public static void ExecutarExemplo003()
    {
        Console.WriteLine("Comparações Lógicas V2");
        Console.WriteLine();
        Console.Write("Favor informar o primeiro número: ");
        int n1 = int.Parse(Console.ReadLine());
        Console.Write("Favor informar o segundo número: ");
        int n2 = int.Parse(Console.ReadLine());
        Console.WriteLine();
        ComparacoesLogicasV2.MaiorQue(n1, n2);
        Console.WriteLine();
        ComparacoesLogicasV2.MenorQue(n1, n2);
        Console.WriteLine();
        Console.ReadLine();
    }

    public static void ExecutarExemplo004()
    {
        TrabalhandoComData.ExibirDataAtual();
        Console.WriteLine();
        TrabalhandoComData.ExibirDataAtualFormatada();
        Console.WriteLine();
    }

    public static void ExecutarExemplo005()
    {
        Console.WriteLine("Operações Matématicas V2");
        Console.WriteLine();
        Console.Write("Favor informar o primeiro número: ");
        int n1 = int.Parse(Console.ReadLine());
        Console.Write("Favor informar o segundo número: ");
        int n2 = int.Parse(Console.ReadLine());
        Console.WriteLine();
        Console.WriteLine("Somar: {0}", OperacoesMatematicas.Somar(n1, n2));
        Console.WriteLine();
        Console.WriteLine("Subtrair: {0}", OperacoesMatematicas.Subtrair(n1, n2));
        Console.WriteLine();
        Console.WriteLine("Multiplicar: {0}", OperacoesMatematicas.Multiplicar(n1, n2));
        Console.WriteLine();
        Console.WriteLine("Dividir: {0}", OperacoesMatematicas.Dividir(n1, n2));
        Console.WriteLine();
        Console.WriteLine("Potenciação (x^y): {0}", OperacoesMatematicasV2.Potenciacao(n1, n2));
        Console.WriteLine();
        Console.WriteLine("Potenciação (y^x): {0}", OperacoesMatematicasV2.Potenciacao(n2, n1));
        Console.WriteLine();
        Console.WriteLine("Radiciação (Raiz Quadrada de N1): {0}", OperacoesMatematicasV2.Radiciacao(n1));
        Console.WriteLine();
        Console.WriteLine("Radiciação (Raiz Quadrada de N2): {0}", OperacoesMatematicasV2.Radiciacao(n2));
        Console.ReadLine();
    }

}
