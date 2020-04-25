using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioFuncionario
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario f = new Funcionario();

            Console.WriteLine("Entre com o Nome, Salario Bruto e Imposto");
            f.Nome = Console.ReadLine();
            f.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            f.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();
            Console.WriteLine(f);

            Console.WriteLine();
            Console.WriteLine("Digite a porcentagem que sera adicionada ao salario");
            double poc = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            f.AumentarSalario(poc);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados" + f);
            
            Console.ReadKey(); 

        }
    }
}
