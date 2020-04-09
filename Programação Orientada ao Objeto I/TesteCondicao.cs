using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste_de_Condição_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double numero = 0;
            Console.Write("Digite um número: ");
            numero = Convert.ToDouble(Console.ReadLine());
            if (numero % 2 == 0)
            {
                Console.WriteLine("PAR");
            }
            else
            {
                Console.WriteLine("IMPAR");
            }

            Console.Read();
        }
    }
}
