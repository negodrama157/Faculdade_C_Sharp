using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testedecondicao3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b = 0;
            Console.Write("Digite um número: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite outro número: ");
            b = Convert.ToInt32(Console.ReadLine());
            if (a > b)
            {
                // Bloco de comandos 1
                Console.WriteLine("O primeiro número é maior que o segundo número! ");
            }
            else if (a < b)
            {
                //Bloco de comandos 2
                Console.WriteLine(" O segundo número é maior que o primeiro número! ");
            }
            else
            {
                //Bloco de comandos 3
                Console.WriteLine("Os dois números são iguais !");

            }

            Console.Read();
        }
    }
}
