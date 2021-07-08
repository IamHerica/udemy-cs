using System;
using System.Globalization;

namespace OperadorTernario
{
    class Program
    {
        static void Main(string[] args)
        {

            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double desconto = (preco < 20.00) ? preco * 0.1 : preco * 0.05;

            Console.WriteLine("Seu desconto foi de:" + desconto.ToString("C1", CultureInfo.CurrentCulture)); //impressão monetária
        }
    }
}
