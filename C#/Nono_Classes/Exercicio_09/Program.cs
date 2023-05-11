using Exercicio_09;
using System;
using System.Globalization;

namespace Exericio_09
{
    class Program
    {
        static void Main(string[] args)
        {
            Dados p1, p2;

            p1 = new Dados();
            p2 = new Dados();
            
            Console.WriteLine("Dados da primeira pessoa: ");
            Console.Write("Nome: ");
            p1.nome1 = Console.ReadLine();
            Console.Write("Idade:");
            p1.idade1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados da Segunda Pessoa: ");
            Console.Write("Nome: ");
            p2.nome2 = Console.ReadLine();
            Console.Write("Idade:");
            p2.idade2 = int.Parse(Console.ReadLine());


            if (p1.idade1 > p2.idade2)
            {
                Console.WriteLine($"Pessoa Mais Velha: {p1.nome1} ");
            }
            else
            {
                Console.WriteLine($"Pessoa mais Velha: {p2.nome2}");
            }
        }
        
    }
}
