using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstrturaCondicional3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com um numero");
            int num = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Entre coum outro número");
            int num2 = Int32.Parse(Console.ReadLine());

            if (num % 2 == 0 && num2 % 2 == 0)
            {
                Console.WriteLine("São Multiplos");
            }
            else
            {
                Console.WriteLine("Não São Multiplos");
            }

            Console.ReadKey();
        }
    }
}
