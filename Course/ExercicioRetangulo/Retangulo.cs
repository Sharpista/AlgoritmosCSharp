using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ExercicioRetangulo
{
    class Retangulo
    {
        public double Largura;
        public double Altura;

        public double CalcularAreaRetangulo() {

            return Altura * Largura;
        }

        public double CalcularPerimetroRetangulo() {

            return 2 * (Altura + Largura);
        }

        public double CalcularDiagonalRetangulo() {

           return Math.Sqrt((Math.Pow(2, Altura) + Math.Pow(2, Largura)));

        }

    }


}
