using System;
using System.Globalization;

namespace Date_Time
{
    class Program
    {
        static void Main(string[] args)
        {

            DateTime d1 = DateTime.Now;
            Console.WriteLine(d1);
            Console.WriteLine(d1.Ticks); //mostra quantos ticks desde meia noite de 01/01 até hoje
            Console.WriteLine();

            DateTime d2 = new DateTime(2021, 06, 23); //instanciar um dia
            Console.WriteLine(d2);
            Console.WriteLine();
            DateTime d3 = new DateTime(2021, 06, 23, 20, 45, 03); //instanciar ano, mes, dia, hora, minuto, segundo
            Console.WriteLine(d3);
            Console.WriteLine();

            DateTime d4 = new DateTime(2021, 06, 23, 20, 45, 03, 500); //instanciar ano, mes, dia, hora, minuto, segundo, milisegundo
            Console.WriteLine(d4); //nao imprime os milisegundos pq precisa de outra formatacao
            Console.WriteLine();

            Console.WriteLine(d1); //dia atual, hora atual
            DateTime d5 = DateTime.Today; //dia atual, hora zerada
            Console.WriteLine(d5);
            DateTime d6 = DateTime.UtcNow; //Coordinated Universal Time
            Console.WriteLine(d6);
            Console.WriteLine();

            //utilizar o parse para gerar data

            DateTime d7 = DateTime.Parse("2002-06-02");
            Console.WriteLine(d7);
            Console.WriteLine();

            DateTime d8 = DateTime.Parse("2002-06-02 18:00:00");
            Console.WriteLine(d8);
            Console.WriteLine();

            DateTime d9 = DateTime.Parse("15/08/2008"); //formato brasil
            Console.WriteLine(d9);
            Console.WriteLine();

            DateTime d10 = DateTime.Parse("15/08/2008 13:09:00"); //formato brasil
            Console.WriteLine(d10);
            Console.WriteLine();

            //personalizando a impressão dos dados
            DateTime d11 = DateTime.ParseExact("2000-08-15", "yyyy-MM-dd", CultureInfo.InvariantCulture);
            Console.WriteLine(d11);

            DateTime d12 = DateTime.ParseExact("15/08/2008 13:57:00", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);
            Console.WriteLine(d12);



        }
    }
}
