using System;


namespace exercicio_estoque_poo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto();

            Console.WriteLine("Entre os dados do produto");
            Console.WriteLine("Nome: ");

            p.Nome =  Console.ReadLine();
            Console.WriteLine("Preço: ");

            p.Preco = double.Parse(Console.ReadLine());
            Console.WriteLine("Quantidade no estoque: ");

            p.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Dados do produto: " + p);

            Console.WriteLine();
            Console.WriteLine("Digite o número de produtos a ser adicionado do estoque: " );
            int qte = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(qte);
             Console.WriteLine("Dados atualizados: " + p );

             
             Console.WriteLine();
             Console.WriteLine("Digite o número de produtos a ser removido do estoque: " );
             qte = int.Parse(Console.ReadLine());
             p.RemoverProdutos(qte);
             Console.WriteLine();
             Console.WriteLine("Dados atualizados: " + p );
        }
    }
}