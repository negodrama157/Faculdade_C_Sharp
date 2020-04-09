using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programatexto
{
    class Program
    {
        static void Main(string[] args)
        {
            string c, c1, d, d1;
            Console.WriteLine("\n Digite a palavra 1: ");
            c = Console.ReadLine();
            Console.WriteLine("\n Digite a palavra 2: ");
            c1 = Console.ReadLine();
            Console.Write("\n tamanho da 1 palavra: {0}" , c.Length);
            Console.Write("\n concatenando sem armazenar: {0}", c + c1);
            d = c;
            Console.Write(" \n o conteúdo de d: {0}", d);
            d1 = c + c1;
            Console.Write("\n concatenação: {0}", d1);
            Console.Write("\n primeiro caractere: {0}", c.Substring(0, 1));
            Console.Write("\n último caractere: {0}", c1.Substring(c1.Length - 1, 1));
            Console.Write("\n todos menos o primeiro: {0}", d1.Substring(1));
            Console.Write("\n o terceiro elemento: {0}", c.Substring(4, 1)); // 5° caracter
            Console.Write("\n os três primeiros elementos: {0}", c.Substring(0, 3));
            Console.Write("\n os três últimos elementos: {0}", c1.Substring(c1.Length -3, 3));
            Console.ReadLine();
        }
    }
}
