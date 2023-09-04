using System.Xml.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Globalization;

namespace exercicio_estoque_poo
{
    public class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public double ValorTotalEmEstoque(){
            return Preco * Quantidade;
        }

        public void AdicionarProdutos (int quantidade){
            Quantidade =  Quantidade + quantidade;
        }

          public void RemoverProdutos (int quantidade){
            Quantidade =  Quantidade - quantidade;
        }

        public override string ToString(){
            return Nome + ", $ " + Preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", " + Quantidade + " unidades, Total: $ " + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }

        
    }
}