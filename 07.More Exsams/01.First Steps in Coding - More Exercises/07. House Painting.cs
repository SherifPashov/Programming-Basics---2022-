using System;

namespace _07._House_Painting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());

            double predna = x * x;
            double pred = (x * x) - (1.2*2);
            double left = (x * y) - (1.5 * 1.5);
            double right = (x * y) - (1.5 * 1.5);

            double roof = x * y * 2;
            double roofTriangle = x * h;

            double greenPaint = predna + pred + left + right;
            double redPaint = roof + roofTriangle;

            greenPaint /= 3.4;
            redPaint /= 4.3;
            Console.WriteLine($"{greenPaint:f2}");
            Console.WriteLine($"{redPaint:f2}");
        }
    }
}
