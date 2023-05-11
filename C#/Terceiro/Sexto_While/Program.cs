using System;
using System.Globalization;

class Setimo_While
{

    static void Main(string[] args)
    {
        Console.Write("Digite um Número:", CultureInfo.InvariantCulture);
        double n1 = double.Parse(Console.ReadLine());

        while (n1 >= 0.0)
        {
            double raiz = Math.Sqrt(n1);
            Console.WriteLine(raiz.ToString("F2", CultureInfo.InvariantCulture));
            Console.Write("Digite um Número:");
            n1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        }
        Console.WriteLine("Numero negativo!!!");
    }
}

