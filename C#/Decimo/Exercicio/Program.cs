using System;
using System.Globalization;

namespace Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            Retangulo r = new Retangulo();
            Console.WriteLine("Digite a Largura e altura do retangulo:");
            Console.Write("Largura: ");
            r.L = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.Write("Altura: ");
            r.A = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            double area = r.Area();
            double perimetro = r.Perimetro();
            double diagonal = r.Diagonal();

            Console.WriteLine($"ÁREA = {area.ToString("F2",CultureInfo.InvariantCulture)}");
            Console.WriteLine($"PERIMETRO = {perimetro.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"DIAGONAL = {diagonal.ToString("F2",CultureInfo.InvariantCulture)}");


        }
    }
}