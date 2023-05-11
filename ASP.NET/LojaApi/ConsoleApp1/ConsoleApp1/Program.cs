using System;
class Program
{
    public static void Main(string[] args)
    {
        {
            float g;
            float a;
            string resp = "sim";
            double result;
           
            while(resp == "sim")
            {
                Console.WriteLine("Digite o valor da Gasolina");
                g = float.Parse(Console.ReadLine());
                Console.WriteLine("Digite o Valor do Alcool");
                a = float.Parse(Console.ReadLine());
                result = a / g;

                if(result > 0.7)
                {
                    Console.WriteLine("abasteça com Alcool");
                }
                else if(result < 0.7)
                {
                    Console.WriteLine("Abasteça com Gasolina");
                }

                else
                {
                    Console.WriteLine("Tanto faz abastecer com álcool ou gasolina");
                }
                Console.WriteLine("Deseja Reafazer o calculo?");
                resp = (Console.ReadLine());
                if (resp != "sim")
                {
                    Console.WriteLine("Programa encerrado");
                    break;
                }
                else
                {
                    Console.Clear();
                }
            }
        }
    }
}
