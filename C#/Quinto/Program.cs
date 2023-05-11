using System;
class Quinto
{
    static void Main(string[] args)
    {
        //    Console.WriteLine("Digite um número inteiro:");
        //    int n1 = int.Parse(Console.ReadLine());

        //    if (n1 % 2 == 0)
        //    {
        //    Console.WriteLine("O número é par!!");
        //    }
        //    else
        //    {
        //    Console.WriteLine("O número é ímpar!!");
        //    }


        Console.WriteLine("Qual a hora atual?");
        int hora = int.Parse(Console.ReadLine());

        if (hora < 12)
        {
            Console.WriteLine("Bom dia!!");
        }

        else if (hora < 18)
        {
            Console.WriteLine("Boa Tarde!!");
        }
        else
        {
            Console.WriteLine("Boa Noite!!");

        }    
        
    }
}