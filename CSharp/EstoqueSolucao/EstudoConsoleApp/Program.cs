using System;
using System.Security.Cryptography.X509Certificates;
using EstudoConsoleApp.Aulas;
using EstudoConsoleApp.Desafios;

namespace EstudoConsoleApp;

public class Program
{
    public static void Main(string[] args)
    {
        //ExecutarExemplo001();
        //ExecutarExemplo002();
        //ExecutarExemplo003();
        //ExecutarExemplo004();
        //ExecutarExemplo005();


        //ExecutarDesafio001();
        ExecutarDesafio002();
        //ExecutarDesafio003();
        //ExecutarDesafio004();
        //ExecutarDesafio005();
        //ExecutarDesafio006();
        //ExecutarDesafio007();
        //ExecutarDesafio008();
        //ExecutarDesafio009();
        //ExecutarDesafio010();
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

    public static void ExecutarDesafio001()
    {
        Desafio001.BoasVindas();
    }

    public static void ExecutarDesafio002()
    {
        Desafio002.DataFormatada();
    }

    public static void ExecutarDesafio003()
    {
        Desafio003.Somar();
    }

    public static void ExecutarDesafio004()
    {
        Desafio004.DobroTriploRaiz();
    }

    public static void ExecutarDesafio005()
    {
        Desafio005.CalcularMedia();
    }

    public static void ExecutarDesafio006()
    {
        Desafio006.ConversorComprimento();
    }

    public static void ExecutarDesafio007()
    {
        Desafio007.Tabuada();
    }

    public static void ExecutarDesafio008()
    {
        Desafio008.Dolar();
    }

    public static void ExecutarDesafio009()
    {
        Desafio009.QtdTinta();
    }

    public static void ExecutarDesafio010()
    {
        Desafio010.Desconto();
    }
}
