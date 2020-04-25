using System;
using System.Globalization;

namespace Banco
{
    class Program
    {
        static void Main(string[] args)
        {


            int n = int.Parse(Console.ReadLine());

            Conta[] vect = new Conta[n];

            for (int i = 0; i < n; i++) {

                string nome = Console.ReadLine();
                double preco = double.Parse(Console.ReadLine());

                vect[i] = new Conta { Nome = nome, Preco = preco };

            }

            double soma = 0.0;

            for (int i = 0; i < n; i++) {

                soma += vect[i].Preco;
            }

            double avg = soma / n;

            Console.WriteLine("AVERAGE PRICE:" +avg.ToString("F2", CultureInfo.InvariantCulture));







            /*int n = int.Parse(Console.ReadLine());

            double[] vect = new double[n];

            for (int i= 0; i < n; i++) {

                vect[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            double soma = 0.0;

            for (int i = 0; i < n; i++) {

                soma += vect[i];
            }

            double avg = soma / n;

            Console.WriteLine("Media das altura :" + avg.ToString("F2", CultureInfo.InvariantCulture));
            */
        }
    }
}
