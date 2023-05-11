using System;
using System.Globalization;

namespace Decimo
{
    class Produto
    {
        // Atributo Privado
        private string _nome;
       
        // Propriedades AutoImplementadas
        public double Preco { get; private set; }
        public int Quantidade { get; private set; }

        // Criando um construtor

        public Produto()
        {

        }
        public Produto(string nome, double preco, int quantidade)
        {
            _nome = nome;
            Preco = preco;
            Quantidade = quantidade;

        }
        
        // Propriedades Customizadas
        public string Nome
        {
            get { return _nome; }
            set
            {
                if (value != null && value.Length > 1)
                {
                    _nome = value;
                }
            }
        }
        public Produto(string nome, double preco)
        {
            _nome = nome;
            Preco = preco;
            Quantidade = 0;

        }

        // OUTROS METODOS DA CLASSE!!!

        // Calculando o valor total em estoque
        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;

        }
        // Adcionando a quantidade de um produto
        public void AdcionarProduto(int quantidade)
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
            return _nome
                + ", $ "
                + Preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + Quantidade
                + " unidades, Total: $ "
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);

        }
    }
}