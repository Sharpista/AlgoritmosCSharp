using System;

namespace Matriz2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Entre com o numero de linhas");
            int l = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o numero de colunas");
            int m = int.Parse(Console.ReadLine());

            int[,] mat = new int[l, m];

            for (int i = 0; i < l; i++) {

                string[] values = Console.ReadLine().Split(' ');

                for (int j = 0; j < m; j++) {

                    mat[i, j] = int.Parse(values[j]);
                }
            }

            Console.WriteLine("Entre com a numero para acessar sua posicao");
            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i < l; i++) {

                for (int j = 0; j < m; j++) {

                    if (mat[i,j] == num) {

                        Console.WriteLine("Posicão: " + i + " , " + j + ":");

                        if (j > 0) {

                            Console.WriteLine("Esquerda: " + mat[i, j - 1]);
                        }
                        if (i > 0) {

                            Console.WriteLine("Acima: " + mat[i -1, j]);
                        }
                        if (j < m - 1) {

                            Console.WriteLine("Direita: " + mat[i, j+1]);
                        }
                        if (i < l - 1) {

                            Console.WriteLine("Abaixo: " + mat[i + 1, j]);
                                
                        }
                    }
                }
            }
            

        }
    }
}
