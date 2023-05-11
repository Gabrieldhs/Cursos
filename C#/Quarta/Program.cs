using System;
using System.Globalization;
class Quarta
{

    static void Main(string[] args)
    {

        int n1 = int.Parse(Console.ReadLine());
        char letra = char.Parse(Console.ReadLine());
        double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        string[] dados = Console.ReadLine().Split(' ');
        string nome = dados[0];
        char sexo = char.Parse(dados[1]);
        int idade = int.Parse(dados[2]);
        double altura = double.Parse(dados[3], CultureInfo.InvariantCulture);


        Console.WriteLine("Você digitou:");
        Console.WriteLine(n1);
        Console.WriteLine(letra);
        Console.WriteLine(n2);
        Console.WriteLine("============================================");
        Console.WriteLine(nome);
        Console.WriteLine(sexo);
        Console.WriteLine(idade);
        Console.WriteLine(altura);
    }
}
