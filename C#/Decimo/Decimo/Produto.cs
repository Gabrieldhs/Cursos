using System;
using System.Globalization;

namespace Decimo
{
    class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        // Criando um construtor
       
        public Produto()
        {

        }
        public Produto(string nome, double preco, int quantidade)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }
        public Produto(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = 0;

        }



        // Calculando o valor total em estoque
        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;

        }
        // Adcionando a quantidade de um produto
        public void AdcionarProduto (int quantidade)
        {
            Quantidade += quantidade;
        }
        // Removendo a quantidade de um produto
        public void RemoverProdouto(int quantidade)
        {
            Quantidade -= quantidade;
        }



        public override string ToString()
        {
            return Nome
                + ", $ "
                + Preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + Quantidade
                + " unidades, Total: $ "
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);

        }
    }
}