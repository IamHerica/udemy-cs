using System;

namespace Funcoes_string
{
    class Program
    {
        static void Main(string[] args)
        {
            string original = "abcde FGHIJ ABC abc DEFG  ";

            string s1 = original.ToUpper();         //maiusculo
            string s2 = original.ToLower();         // minusculo
            string s3 = original.Trim();            // apagar espacos em branco no inicio e no fim
            string s4 = original.Substring(3);      //cortar tudo que esta a frente dessa posicao
            string s5 = original.Substring(3, 5);    //cortar apartir da posicao 3, 5 caracteres
            string s6 = original.Replace('a', 'x'); //alterar o caractere 'a' por 'x'

            int n1 = original.IndexOf("bc");        //primeira posicao de onde se encontra 'bc'
            int n2 = original.LastIndexOf("bc");    //ultima posicao de onde se encontra 'bc'

            bool b1 = string.IsNullOrEmpty(original);      //verifica se a string é vazia ou nula
            Console.WriteLine("IsNullOrEmpty:\n" + b1);

            bool b2 = string.IsNullOrWhiteSpace(original); //verifica se deixou a string apenas com espaco em branco
            Console.WriteLine("IsNullOrEmpty:\n" + b2);


            Console.WriteLine("To Upper:");
            Console.WriteLine($"-{s1}-");

            Console.WriteLine("To Lower:");
            Console.WriteLine($"-{s2}-");

            Console.WriteLine("Trim:");
            Console.WriteLine($"-{s3}-");

            Console.WriteLine("Substring:");
            Console.WriteLine($"-{s4}-");

            Console.WriteLine("Substring(3, 5):");
            Console.WriteLine($"-{s5}-");


            Console.WriteLine("Replace de 'a' por 'x':");
            Console.WriteLine($"-{s6}-");

            Console.WriteLine("IndexOf('bc):");
            Console.WriteLine($"{n1}");

            Console.WriteLine("LastIndexOf('bc'):");
            Console.WriteLine($"{n2}");
        }
    }
}
