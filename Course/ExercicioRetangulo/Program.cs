using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Threading.Tasks;

namespace ExercicioRetangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            Retangulo r = new Retangulo();

            Console.WriteLine("Entre com a Altura e Largura do Retangulo");
            r.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            r.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("AREA :" + r.CalcularAreaRetangulo().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("PERIMETRO :" + r.CalcularPerimetroRetangulo().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("DIAGONAL :" + r.CalcularDiagonalRetangulo().ToString("F2", CultureInfo.InvariantCulture));

            Console.ReadKey();
            
          
            



        }
    }
}
