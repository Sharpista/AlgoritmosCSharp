using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioAlunos
{
    class Alunos
    {
        public String Nome;
        public double Nota1;
        public double Nota2;
        public double Nota3;

        public void NotaFinal() {

            double notaFinal = (Nota1 + Nota2 + Nota3);

            if (notaFinal >= 60.0)
            {
                Console.WriteLine("Nota Final" + notaFinal.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("APROVADO");
            }
            else {

                double resta = 60.0 - notaFinal;

                Console.WriteLine("Nota Final "+ notaFinal.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("REPROVADO");
                Console.WriteLine("Restam" + resta + "pontos");

            }

            
            
        }
    }
}
