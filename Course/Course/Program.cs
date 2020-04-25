using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto();

            Console.WriteLine("Entre com o nome do produto");
            p.Nome = Console.ReadLine();

            Console.WriteLine("Entre com o preco do produto");
            p.Preco = double.Parse(Console.ReadLine());

            Console.WriteLine("Entre com a quantidade de produtos");
            p.Quantidade = Int32.Parse(Console.ReadLine());

            
            Console.WriteLine("Dados do produto :" + p);

            Console.WriteLine();
            Console.Write("Digite o numero de produtos a serem adicionados ao estoque");
            int qte = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(qte);

            Console.WriteLine();
            Console.Write("Dados Atualizados: "+ p);

            Console.WriteLine();
            Console.WriteLine("Digite o numero de produtos a serem removidos do estoque");
            qte = int.Parse(Console.ReadLine());
            p.RemoverProduto(qte);

            Console.WriteLine();
            Console.WriteLine("Dados Atualizados:"+ p);



           





        }
    }
}
