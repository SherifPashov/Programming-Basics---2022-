using System;

namespace _03._Celsius_to_Fahrenheit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double celzii = double.Parse(Console.ReadLine());
            double farenhai = celzii * 9 / 5 + 32;
            Console.WriteLine($"{farenhai:f2}");
        }
    }
}
