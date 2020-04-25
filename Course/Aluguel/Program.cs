using System;

namespace Aluguel
{
    class Program
    {
        static void Main(string[] args)
        {

            Pessoa[] vect = new Pessoa[10];

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++) {

                Console.WriteLine();
                Console.WriteLine($"Aluguel: #{i}");
                Console.WriteLine("Nome:");
                string nome = Console.ReadLine();
                Console.WriteLine("Email");
                string email = Console.ReadLine();
                Console.WriteLine("Quarto");
                int quarto = int.Parse(Console.ReadLine());
                vect[quarto] = new Pessoa { Nome = nome, Email = email };
                
            }

            Console.WriteLine();
            Console.WriteLine("Quartos ocupados");
            for (int i = 0; i < 10; i++) {

                if (vect[i] != null) {

                    Console.WriteLine(i +": " + vect[i]);
                }
            
            }

            

            

        }
    }
}
