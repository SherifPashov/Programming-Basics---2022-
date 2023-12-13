using System;

namespace _05._Training_Lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
           double w = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());
            h = (h * 100) - 100;
            w = (w * 100);
           
            double hMesta = Math.Floor(h / 70);
            double wMesta = Math.Floor(w / 120);
            double allMesta = (wMesta * hMesta) - 3;
            Console.WriteLine(allMesta);
        }
    }
}
