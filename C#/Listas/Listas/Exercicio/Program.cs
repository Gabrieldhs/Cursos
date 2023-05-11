using System;
using System.Collections.Generic;
using System.Globalization;
namespace Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos Funcionários serão cadastrados: ");
            int n = int.Parse(Console.ReadLine());

            List<Empregado> lista = new List<Empregado>();

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Empregado #" + i + ":" );
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Salario: ");
                double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                lista.Add(new Empregado(id, nome, salario));
                Console.WriteLine();
            }

            Console.Write("Insira o ID do funcionário que terá aumento salarial: ");
            int pesquisa = int.Parse(Console.ReadLine());

            Empregado emp = lista.Find(x => x.Id == pesquisa);
            if (emp != null)
            {
                Console.WriteLine("Entre com a porcentagem: ");
                double porcentagem = double.Parse(Console.ReadLine());
                emp.AumentoSalario(porcentagem);
            }
            else
            {
                Console.WriteLine("Essa identificação: ");
            }

            Console.WriteLine();
            Console.WriteLine("Lista atualizada de funcionários:");
            foreach (Empregado obj in lista){
                Console.WriteLine(obj);
      }
    }   
  }
}