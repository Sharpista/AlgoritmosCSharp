using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstruturaSequencial
{
    class Program
    {
        static void Main(string[] args)
        {
           
           


            Console.WriteLine("Entre com um número");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com outro número");
            int b = int.Parse(Console.ReadLine());

            int soma = a + b;

            Console.WriteLine($"A Soma de {a} e {b} é igual a {soma}");

            Console.ReadKey();
        }
    }
}
