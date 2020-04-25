using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstrtuturaCondicional2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com um número");
            int num = Int32.Parse(Console.ReadLine());

            if (num % 2 == 0)
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
