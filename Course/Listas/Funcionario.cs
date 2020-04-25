using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Listas
{
    class Funcionario
    {
        private int _id;
        private string _nome;
        private double _salario;


        public int Id { get => _id; set => _id = value; }
        public string Nome { get => _nome; set => _nome = value; }
        public double Salario { get => _salario; set => _salario = value; }


        public void aumentarSalario(double porcentagem) { 
        
            Salario += Salario * porcentagem / 100.0;
        }

        public override string ToString()
        {
            return Id + " " + Nome + " " + Salario.ToString("F2", CultureInfo.InvariantCulture);
        }


    }
}
