using System;
using System.Globalization;

class Exercicio
{
    static void Main(string[] args)
    { 
        Console.WriteLine("Digite o seu Nome Completo: ");
        string nome = Console.ReadLine();
        
        Console.WriteLine("Digite quantos quartos você tem na sua casa:");
        int qtde = int.Parse(Console.ReadLine());
       
        Console.WriteLine("Digite o Peço do Produto:");
        double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        
        Console.WriteLine("Digite o seu último nome, idade, e altura(mesma linha): ");
        string[] dados = Console.ReadLine().Split(' ');
        string ultimoNome = dados[0];
        int idade = int.Parse(dados[1]);
        double altura = double.Parse(dados[2], CultureInfo.InvariantCulture);

        Console.WriteLine(nome);
        Console.WriteLine(qtde);
        Console.WriteLine(preco);
        Console.WriteLine(ultimoNome);
        Console.WriteLine(idade);
        Console.WriteLine(altura.ToString(CultureInfo.InvariantCulture));

    }



}