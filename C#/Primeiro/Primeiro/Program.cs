using System;

class Primeiro
{


    static void Main(string[] args)
    {

        string produto1 = "Computador";
        string produto2 = "Mesa de Escritório";

        byte idade = 30;
        int codigo = 5290;
        char genero = 'M';

        double preco1 = 2100.0;
        double preco2 = 650.50;
        double medida = 53.234567;

        Console.WriteLine("Produto: ");

        Console.WriteLine($"{produto1}, cujo o preço é: {preco1:c}");
        Console.WriteLine($"{produto2}, cujo o preço é: {preco2:c}");
        
        Console.WriteLine($"Registro: {idade} anos de idade, código {codigo} e genero {genero}");

        Console.WriteLine($"Medida com oito casas decimais: {medida:F8}");
        Console.WriteLine($"Arredondando (três casas decimais): {medida:F3}");
       
       

    }
}