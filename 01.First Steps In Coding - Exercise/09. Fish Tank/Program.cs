using System;

namespace _09._Fish_Tank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());
            double persent = double.Parse(Console.ReadLine());

            double v = a * b * h;
            double persentfree = (100 - persent) / 100;
            double freeV = v * persentfree / 1000;
            Console.WriteLine(freeV);



        }
    }
}
