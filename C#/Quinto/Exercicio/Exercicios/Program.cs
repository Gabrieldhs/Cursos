using System;
using System.Globalization;
class Exercicio
{
    static void Main(string[] args)
    {
        // dizer se este número é negativo ou não.
        Console.WriteLine("EXERCICIO 1");
        Console.WriteLine("Digite um número inteiro:");
        int n1 = int.Parse(Console.ReadLine());

        if (n1 < 0)
        {
            Console.WriteLine("Negativo");
        }
        else
        {
            Console.WriteLine("Positivo");
        }
        // dizer se este número é par ou ímpar
        Console.WriteLine("==================");
        Console.WriteLine("EXERCICIO 2");

        Console.WriteLine("Digite um número:");
        int n2 = int.Parse(Console.ReadLine());

        if (n2 % 2 == 0)
        {
            Console.WriteLine("Número Par!!!");

        }
        else
        {
            Console.WriteLine("Número Impar!!");
        }
        // mostrar uma mensagem "Sao Multiplos" ou Não
       
        Console.WriteLine("==================");
        Console.WriteLine("EXERCICIO 3");
       
        Console.WriteLine("Digite dois números:");

        string[] valores = Console.ReadLine().Split(" ");
        int valor1 = int.Parse(valores[0]);
        int valor2 = int.Parse(valores[1]);

        if (valor1 % valor2 == 0 || valor2 % valor1 == 0) {
            Console.WriteLine("São Multiplos!!");
        }
         else
        {
            Console.WriteLine("Não são multiplos");
        }

        Console.WriteLine("==================");
        Console.WriteLine("EXERCICIO 4");
       
        Console.WriteLine("Digite dois horários:");
        string[] hora = Console.ReadLine().Split(' ');
        int horaInicial = int.Parse(hora[0]);
        int horaFinal = int.Parse(hora[1]);

        int duração;
        if (horaInicial < horaFinal)
        {
            duração = horaFinal - horaInicial;
        }
        else
        {
            duração = 24 - horaInicial + horaFinal;

        }

        Console.WriteLine($"O JOGO DUROU {duração} HORA(S)");

        Console.WriteLine("==================");
        Console.WriteLine("EXERCICIO 5");
        Console.WriteLine("Digite dois itens:");

        string[] valores1 = Console.ReadLine().Split(' ');
        int codigo = int.Parse(valores[0]);
        int quantidade = int.Parse(valores1[1]);

        double total1;
        if(codigo == 1)
        {
            total1 = quantidade * 4.0;

        }
        else if (codigo == 2)
        {
            total1 = quantidade * 4.5;
        }

        else if (codigo == 3)
        {
            total1 = quantidade * 5.0;
        }
        else if (codigo == 4)
        {
            total1 = quantidade * 2.0;
         }
        else
        {
            total1 = quantidade * 1.5;
       }
        Console.WriteLine("Digite dois itens:");
        Console.WriteLine($"Total: {total1}");
    }
}