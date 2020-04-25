using System;
using System.Collections.Generic;
using System.Globalization;

namespace Listas
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Deseja cadastrar quantos funcionarios");
            int n = int.Parse(Console.ReadLine());

            List<Funcionario> listaFunc = new List<Funcionario>();
            

            for (int i = 0; i < n; i++) {

                Funcionario fun = new Funcionario();
                Console.WriteLine("");
                Console.WriteLine($"Funcionario #{i}");
                Console.WriteLine("ID :");
                fun.Id = int.Parse(Console.ReadLine());
                Console.WriteLine("Nome :");
                fun.Nome = Console.ReadLine();
                Console.WriteLine("Salario");
                fun.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                listaFunc.Add(fun);
                Console.WriteLine();

            }

            
            Console.WriteLine("Entre com o id do funcionario que receberá o aumento");
            int aux = int.Parse(Console.ReadLine());
            Funcionario fun1 = listaFunc.Find(x => x.Id == aux);

            if (fun1 != null) {
                
                Console.WriteLine("Entre com a porcentagem");
                double perc = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                fun1.aumentarSalario(perc);
            }
            else {
                Console.WriteLine("Id não encontrado !");
            }
            Console.WriteLine();

            Console.WriteLine("Lista atualizada");
            foreach (Funcionario funcionario in listaFunc) {
                Console.WriteLine(funcionario);
            }  




            Console.WriteLine(); 

            
           

        }
    }
}
