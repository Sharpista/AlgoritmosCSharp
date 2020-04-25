using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstruturaCondicional
{
    class Exercicio1
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Entre com um número");
            int num = Int32.Parse(Console.ReadLine());

            if (num >= 0)
            {
                Console.WriteLine("Não Negativo");
            }
            else 
            {
                Console.WriteLine("Negativo");
            }

            Console.ReadKey();
        }
    }
}
