using System;
using System.Collections.Generic;

namespace Listas
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();

            list.Add("Maria");
            list.Add("Alex");
            list.Add("Bob");
            list.Add("Ana");

            list.Insert(2, "Marco");

            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine("Tamanho da lista:" + list.Count);

            string s1 = list.Find(x => x[0] == 'A');
            Console.WriteLine("1ª pessoa com o nome que começa com A: " + s1);

            string s2 = list.FindLast(x => x[0] == 'A');
            Console.WriteLine("Ultima pessoa que o nome começa com A: " + s2);

            int pos1 = list.FindIndex(x => x[0] == 'A');
            Console.WriteLine("Primeira posição de quem começa com A: " + pos1);

            int pos2 = list.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine("Ultima posição de quem começa com A: " + pos2);

            Console.WriteLine("------------------");
            list.RemoveRange(2, 2); //na posicao 2, quero remover ele e mais um
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine("------------------");
            Console.WriteLine("Todos que o nome tem 5 letras:");
            List<string> resultado = list.FindAll(x => x.Length == 5);
            foreach (string obj in resultado)
            {
                Console.WriteLine(obj);
            }



            Console.WriteLine("------------------");
            Console.WriteLine("Removendo o Alex");
            list.Remove("Alex");

            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine("------------------");
            Console.WriteLine("Removendo quem está na posição 0:");
            list.RemoveAt(0);

            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine("------------------");
            Console.WriteLine("Removendo todos que começam com M:");
            list.RemoveAll(x => x[0] == 'M');

            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }


        }
    }
}
