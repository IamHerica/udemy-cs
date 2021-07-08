using Course.Model.Entities;
using System;
using Course.Model.Enum;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {

            IShape s1 = new Circle() { Radius = 2.0, Color = Color.White };
            IShape r2 = new Rectangle() { Width = 3.5, Color = Color.Black, Height = 4.2 };

            Console.WriteLine(s1);
            Console.WriteLine(r2);
        }
    }
}
