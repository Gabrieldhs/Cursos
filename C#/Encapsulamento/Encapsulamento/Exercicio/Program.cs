using System;
using System.Globalization;

namespace Exercicio
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Conta conta;

            Console.Write("Digite o número da conta: ");
            int numero = int.Parse(Console.ReadLine());

            Console.Write("Digite o seu Nome Completo: ");
            string titular = Console.ReadLine();

            Console.Write("Havera deposito inicial? Digite (s/n):  ");
            char opcao = char.Parse(Console.ReadLine());
            if (opcao == 's'|| opcao == 'S')
            {
                Console.Write("Digite o valor de deposito Inicial: ");
                double depositoInicial = double.Parse(Console.ReadLine());

                conta = new Conta(numero, titular, depositoInicial);
            }
            else
            {
                conta = new Conta(numero, titular);
            }

            Console.WriteLine();
            Console.WriteLine("Dados da conta: ");
            Console.WriteLine(conta);

            Console.WriteLine();
            Console.Write("Digite um valor para deposito: ");
            double quantia = double.Parse(Console.ReadLine());
            conta.Deposito(quantia);
            Console.WriteLine("Dados da conta atualizado!!");
            Console.WriteLine(conta);

            Console.WriteLine();
            Console.Write("Digite um valor para saque: ");
            quantia = double.Parse(Console.ReadLine());
            conta.Saque(quantia);
            Console.WriteLine("Dados atualizados!!");
            Console.WriteLine(conta);

        }
    }
}