using System;

class Segundo
{
    static void Main(string[] args)
    {

        int n1 = 3 + 4 * 3;
        int n2 = (4 + 2) * 4;
        int n3 = 17 % 3;            // Irá retornar a sobra
        double n4 = 10.0 / 3.0;

        // REALIZANDO A RAIZ QUADRADA

        double a = 1.0, b = -3.0, c = -4.0;

        double delta = Math.Pow(b, 2.0) - 4.0 *a * c; // MATH.POW = Pontencia (variável, CasaPotencial)

        double x1 = (-b + Math.Sqrt(delta)) / (2.0 * a); // MATH.SQRT = Raiz Quadrada
        double x2 = (-b - Math.Sqrt(delta)) / (2.0 * a);

        Console.WriteLine("n1: " + n1);
        Console.WriteLine("n2: " + n2);
        Console.WriteLine("n3: " + n3);
        Console.WriteLine("n4: " + n4);
        Console.WriteLine("Delta: " + delta);
        Console.WriteLine("x1: " + x1);
        Console.WriteLine("x2:" + x2);
    }

} 