using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testefor4
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Texto = new string[5];
            Texto[0] = "Palavra 1 ";
            Texto[1] = "Palavra 2 ";
            Texto[2] = "Palavra 3 ";
            Texto[3] = "Palavra 4 ";
            Texto[4] = "Palavra 5 ";
            int i = 0;
            foreach (string s in Texto)
            {
                Console.WriteLine($" Iteração: {i} - {s}");
                i++;
            }
            Console.Read();
        }
    }
}
