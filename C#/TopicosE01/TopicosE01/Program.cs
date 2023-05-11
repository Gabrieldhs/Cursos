using System;
namespace TopicosE01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("01 -- Inserindo o var, não necessita declarar a variável.");
            var x = 20;
            var y = 30.0;
            var z = 'c';
            var a = "Maria";
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
            Console.WriteLine(a);
            Console.WriteLine("================================================================");
            Console.WriteLine();
            Console.WriteLine("02 -- (switch - case) poderá substituir o if-else encadeado."); 

            int diaSeamana = int.Parse(Console.ReadLine());
            string dia;

            switch (diaSeamana)
            {
                case 1:
                    dia = "Domingo";
                    break;
                case 2:
                    dia = "Segunda";
                    break;
                case 3:
                    dia = "Terça";
                    break;
                case 4:
                    dia = "Quarta";
                    break;
                case 5:
                    dia = "Quinta";
                    break;
                case 6:
                    dia = "Sexta";
                    break;
                case 7:
                    dia = "Sabado";
                    break;
                default:
                    dia = "Dia inválido";
                    break;
            }
            Console.WriteLine($"Dia: {dia}");

            Console.WriteLine("================================================================");
            Console.WriteLine();
            Console.WriteLine("03 -- Funções para String");
            string original = "abcde FGHIJ ABC abc DEFG ";
            // Formatando em Letra Maisucula
            string letra1 = original.ToUpper();
            // Formatando em Letra minuscula
            string letra2 = original.ToLower();
            // Formatando para eliminar os espaços em Branco
            string letra3 = original.Trim();
            // Verificando a posição das letras B e C
            int nu1 = original.IndexOf("bc");
            // Verificando letra por letra a posição de B e C
            int nu2 = original.LastIndexOf("BC");
            // Cortando a string na posição 5 = abcde
            string letra4 = original.Substring(5);
            // Cortando 5 characteres a partir da posição 3
            string letra5 = original.Substring(3, 5);
            // Substituindo a letra 'a'pela letra 'x'
            string letra6 = original.Replace('a', 'x');
            // Substituindo as letras 'abc'para 'xy'
            string letra7 = original.Replace("abc", "xy");
            // Verificando se a String é vázia
            bool boolean1 = String.IsNullOrEmpty(original);
            // Verificando se possui Espaço em branco
            bool boolean2 = String.IsNullOrWhiteSpace(original);

            Console.WriteLine($"Original:-{original}- ");
            Console.WriteLine($"ToUpper: -{letra1}-");
            Console.WriteLine($"ToLower:-{letra2}-");
            Console.WriteLine($"Trim:-{letra3}-");
            Console.WriteLine($"IndexOf: -{nu1}-");
            Console.WriteLine($"LastIndexOf:-{nu2}-");
            Console.WriteLine($"SubString:-{letra4}-");
            Console.WriteLine($"SubString: -{letra5}-");
            Console.WriteLine($"Replace: -{letra6}-");
            Console.WriteLine($"Replace 2:-{letra7}-");
            Console.WriteLine($"IsNullOrEmpty:-{boolean1}-");
            Console.WriteLine($"IsNullOrWhiteSpace:-{boolean2}-");

            Console.WriteLine("================================================================");
            Console.WriteLine();
            Console.WriteLine("04 -- Propriedades com o DateTimec ");

            DateTime d = new DateTime(2001, 8, 15, 13, 45, 58, 275);
            Console.WriteLine(d);
            Console.WriteLine("1) Date: " + d.Date);
            Console.WriteLine("2) Day: " + d.Day);
            Console.WriteLine("3) DayOfWeek: " + d.DayOfWeek);
            Console.WriteLine("4) DayOfYear: " + d.DayOfYear);
            Console.WriteLine("5) Hour: " + d.Hour);
            Console.WriteLine("6) Kind: " + d.Kind);
            Console.WriteLine("7) Millisecond: " + d.Millisecond);
            Console.WriteLine("8) Minute: " + d.Minute);
            Console.WriteLine("9) Month: " + d.Month);
            Console.WriteLine("10) Second: " + d.Second);
            Console.WriteLine("11) Ticks: " + d.Ticks);
            Console.WriteLine("12) TimeOfDay: " + d.TimeOfDay);
            Console.WriteLine("13) Year: " + d.Year);
        }
    }
}
