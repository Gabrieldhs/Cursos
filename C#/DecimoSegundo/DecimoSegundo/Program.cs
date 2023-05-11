using System;
using System.Globalization;

namespace DecimoSegundo
{
    class Program
    {
        
        static void Main(string[] args)
        {
            /*// Lendo um número inteiro
            int n = int.Parse(Console.ReadLine());
            double[] vect = new double[n];

            for (int i = 0; i < n; i++)
            {
                // Lendo a altura das pessoas e armazenando a altura em um Vetor
                vect[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }
            double sum = 0;
            for (int i = 0; i < n; i++)
            {
                sum += vect[i];
            }

            double avg = sum / n;
            Console.WriteLine($"A altura média é igual: {avg.ToString("F2",CultureInfo.InvariantCulture)}");
           */

            int n = int.Parse(Console.ReadLine());
            Produto[] vect = new Produto[n];

            for  (int i = 0;i < n; i++)
            {
                string nome = Console.ReadLine();
                double preco = double.Parse(Console.ReadLine());
                vect[i] = new Produto { Nome= nome , Preco=preco};
            }

            double sum = 0;
            for (int i = 0; i < n; i++)
            {
                sum += vect[i].Preco;

            }
            double avg = sum / n;
            Console.WriteLine($"A média do preço é:{avg:c} ");
        }
    }
}