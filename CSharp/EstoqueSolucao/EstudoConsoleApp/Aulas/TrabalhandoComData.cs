using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudoConsoleApp.Aulas
{
    public static class TrabalhandoComData
    {
        public static void ExibirDataAtual()
        {
            Console.WriteLine("Hoje é {0}", DateTime.Now);
        }

        public static void ExibirDataAtualFormatada()
        {
            DateTime date = DateTime.Now;
            Console.WriteLine(date.ToString("MM/dd/yyyy"));
            Console.WriteLine(date.ToString("dddd, dd MMMM yyyy"));
            Console.WriteLine(date.ToString("dddd, dd MMMM yyyy"));
            Console.WriteLine(date.ToString("dddd, dd MMMM yyyy"));
            Console.WriteLine(date.ToString("dddd, dd MMMM yyyy"));
            Console.WriteLine(date.ToString("dddd, dd MMMM yyyy"));
            Console.WriteLine(date.ToString("dddd, dd MMMM yyyy HH:mm:ss"));
            Console.WriteLine(date.ToString("MM/dd/yyyy HH:mm"));
            Console.WriteLine(date.ToString("MM/dd/yyyy hh:mm tt"));
            Console.WriteLine(date.ToString("MM/dd/yyyy H:mm"));
            Console.WriteLine(date.ToString("MM/dd/yyyy h:mm tt"));
            Console.WriteLine(date.ToString("MM/dd/yyyy HH:mm:ss"));
            Console.WriteLine(date.ToString("MMMM dd"));
            Console.WriteLine(date.ToString("yyyy’-‘MM’-‘dd’T’HH’:’mm’:’ss.fffffffK"));
            Console.WriteLine(date.ToString("ddd, dd MMM yyy HH’:’mm’:’ss ‘GMT’"));
            Console.WriteLine(date.ToString("yyyy’-‘MM’-‘dd’T’HH’:’mm’:’ss"));
            Console.WriteLine(date.ToString("HH:mm"));
            Console.WriteLine(date.ToString("hh:mm tt"));
            Console.WriteLine(date.ToString("H:mm"));
            Console.WriteLine(date.ToString("h:mm tt"));
            Console.WriteLine(date.ToString("HH:mm:ss"));
            Console.WriteLine(date.ToString("yyyy MMMM"));
        }
    }
}
