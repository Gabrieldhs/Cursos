using System;

class Oitavo_For
{
    static void Main(string[] args)
    {
        Console.Write("Digite a quantidade de número inteiro que você deseja: ");
        int N = int.Parse(Console.ReadLine());

        int soma = 0;

        for  (int i = 1; i <= N; i++)
        {
            Console.Write("O valor #{0}: ", i);
            int valor = int.Parse(Console.ReadLine());

            soma += valor;

            
       }

            Console.Write("A soma = " + soma);
    }

}