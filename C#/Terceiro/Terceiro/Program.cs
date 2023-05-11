using System;

class Terceiro
{

    static void Main(string[] args)
    {
        string frase = Console.ReadLine();
        string x = Console.ReadLine();
        string y = Console.ReadLine();
        string z = Console.ReadLine();

        // Quebrando a linha de texto em 3.
        string[] cor = Console.ReadLine().Split(" ");
        string cor1 = cor[0];
        string cor2 = cor[1];
        string cor3 = cor[2];

        Console.WriteLine("Você digitou:");
        Console.WriteLine(frase);
        Console.WriteLine(x);
        Console.WriteLine(y);
        Console.WriteLine(z);
        Console.WriteLine(cor1);
        Console.WriteLine(cor2);
        Console.WriteLine(cor3);


    }
}
