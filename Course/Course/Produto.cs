using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Course
{
    class Produto
    {
       public String Nome;
       public Double Preco;
       public  int Quantidade;

        public double ValorTotalEmEstoque() {
            return Preco * Quantidade;       
        }

        public void RemoverProduto(int quantidade) {
            Quantidade = Quantidade - quantidade;
        }

        public void AdicionarProdutos(int quantidade) {
            Quantidade = Quantidade + quantidade;            
        }
        public override string ToString()
        {
            return Nome 
                + ", $ " 
                + Preco.ToString("F2",CultureInfo.InvariantCulture) 
                + ","
                + Quantidade
                +"unidades, Total: $"
                + ValorTotalEmEstoque().ToString("F2",CultureInfo.InvariantCulture);
        }
    }
}
