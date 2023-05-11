using System;
using System.Globalization;

namespace Exercicio_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario dados = new Funcionario();
            Console.Write("Nome: ");
            dados.Nome = Console.ReadLine();

            Console.Write("Salario Bruto: ");
            dados.SalarioBruto= double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Imposto: ");
            dados.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Funcionario: " + dados);
            Console.WriteLine();

            Console.Write("Digite a porcentagem para aumentar o salario:");
            double porcent = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            dados.AumentarSalario(porcent);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + dados);
        }
    }
}
