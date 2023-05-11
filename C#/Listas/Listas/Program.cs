using System;
using System.Collections.Generic;
namespace Listas
{
    class Program
    {
        static void Main(string[] args)
        {
            // Criando uma lista!!!
            List<string> lista = new List<string>();
            lista.Add("Maria");
            lista.Add("Alex");
            lista.Add("Marco");
            lista.Add("Bob");
            lista.Add("Anna");
            lista.Insert(2, "Gabriel");

            foreach (string obj in lista)
            {
                Console.WriteLine(obj);
            }

            // Realizando uma contagem de pessoas na Lista.
            Console.WriteLine("Contagem de pessoas: " + lista.Count);

            // Encontrando as pessoas que iniciam o nome com a Letra 'A'
            string s1 = lista.Find(x => x[0] == 'A');
            Console.WriteLine("A  pessoa com a letra 'A': " + s1);
            // Encontrando as pessoas que terminam o nome com a Letra 'A'
            string s2 = lista.FindLast(x => x[0] == 'A');
            Console.WriteLine("A pessoa com a última A: " + s2);
            // Encontrando a posição que começam com a letra 'A'
            int pos1 = lista.FindIndex(x => x[0] == 'A');
            Console.WriteLine("Primeira Posição 'A': " + pos1);
            // Encontrando a posição que terminam com a letra 'A'
            int pos2 = lista.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine("Última posição 'A':  " +pos2);
            // Encontrando as pessoas que possuem 5 letras no nome.
            List<string> lista2 = lista.FindAll(x => x.Length == 5);
            Console.WriteLine("===========================");
            foreach (string obj in lista2)
            {
                Console.WriteLine(obj);
            }
            // Deletando a pessoa da Lista.
            lista.Remove("Gabriel");
            Console.WriteLine("===========================");
            foreach (string obj in lista)
            {
                Console.WriteLine(obj);
            }
            // Removendo as pessoas que começam com a letra 'M'
            lista.RemoveAll(x => x[0] == 'M');
            Console.WriteLine("===========================");
            foreach (string obj in lista)
            {
                Console.WriteLine(obj);
            }


        }   
    }
}