using System;
using System.Globalization;

namespace Decimo
{
    class Program
    {
        static void Main(string[] args)
        {
           
            // Digitando o nome do produto
            Console.WriteLine("Digite os dados do produto: ");
            Console.Write("Nome do Produto: ");
            string nome = Console.ReadLine();

            // Digitando o preço do produto
            Console.Write("Peço do Produto: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            // Digitando a quantidade do produto
            Console.Write("Quantidade: ");
            int quantidade = int.Parse(Console.ReadLine());

            Produto p = new Produto(nome, preco, quantidade);

            Produto p2 = new Produto();

            Console.Write($"Dados do Produto: {p}");

            Console.WriteLine();
            Console.Write("Digite o numero de produtos a ser adcionado ao estoque: ");
            
            // Adicionando uma nova quantidade de produto
            int qtde = int.Parse(Console.ReadLine());
            p.AdcionarProduto(qtde);
            Console.WriteLine($"Dados atualizados: {p}");

            Console.WriteLine();
            
            // Removendo uma quantidade de produto
            Console.Write("Digite o numero de produtos a ser removido: ");
            qtde = int.Parse(Console.ReadLine());
            p.RemoverProdouto(qtde);
            Console.Write($"Dados atualizados: {p}");
            
            



        }    
    }
}
