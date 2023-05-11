using System;

class Aula05
{ 
    static void Main()
{
    // double n1, n2, n3;
    // n1 = 4.6;
    // n2 = 9.5;
    // n3 = 8.6;

    //Console.Write("\nNota1 =\t{0} \nNota2 =\t{1} \nNota3 =\t{2}",n1,n2,n3);


    double valorCompra = 7.50;
    double valorVenda;
    double Lucro = 0.2;
    string produto = "Sorvete";

        valorVenda = valorCompra + (valorCompra * Lucro);


    Console.WriteLine("Produto...........{0,15}", produto);
    Console.WriteLine("Valor de Compra...{0,15:c}", valorCompra);
    Console.WriteLine("Lucro.............{0,15:p}", Lucro);
    Console.WriteLine("Valor de venda....{0,15:c}", valorVenda);

}

}


