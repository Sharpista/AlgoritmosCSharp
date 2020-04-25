using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioAlunos
{
    class Program
    {
        static void Main(string[] args)
        {
            Alunos alunos = new Alunos();
            Console.WriteLine("Entre com o Nome do Aluno");
            alunos.Nome = Console.ReadLine();

            Console.WriteLine("Entre com as Notas do Aluno");
            alunos.Nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            alunos.Nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            alunos.Nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            alunos.NotaFinal();

            Console.ReadKey();


        }
    }
}
