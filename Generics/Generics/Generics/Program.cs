using System;
//reuso, parametrizado por tipo
namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {

            PrintService<string> printService = new PrintService<string>();


            Console.Write("How many values? ");
            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i < num; i++)
            {
                string x = Console.ReadLine();
                printService.AddValue(x);
            }

            printService.Print();
            Console.Write("First: " + printService.First());
        }
    }
}
