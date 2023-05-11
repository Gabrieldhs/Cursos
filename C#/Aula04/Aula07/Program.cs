using System;
    class Aula07
{
    static void Main()
    {

        string nome;
        int idade;
        double altura;
        string endereço;

        Console.WriteLine("Digite o seu Nome: ");
        nome = Console.ReadLine();
        Console.WriteLine("Digite a sua idade: ");
        idade =int.Parse (Console.ReadLine());
        Console.WriteLine("Digite a sua Altura: ");
        altura =double.Parse(Console.ReadLine());
        Console.WriteLine("Digite o o seu endereço: ");
        endereço = Console.ReadLine();
        Console.WriteLine("Dados inseridos com sucesso!!!");


        double nota1, nota2, soma;
   

   

        Console.WriteLine("Digite a AV1");
        nota1 = double.Parse(Console.ReadLine());
        Console.WriteLine("Digite a AV2");
        nota2 = double.Parse(Console.ReadLine());
        soma= (nota1 + nota2);
        Console.WriteLine("Somando a Nota AV1 {0} e a Nota AV2 {1}, o resultado será: {2}  ", nota1, nota2,soma);



    }





}
