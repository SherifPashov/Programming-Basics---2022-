using System;

namespace _09._Weather_Forecast
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string vreme = Console.ReadLine();

            if (vreme == "sunny")
            {
                Console.WriteLine($"It's warm outside!");
            }
            else
            {
                Console.WriteLine($"It's cold outside!");     
            }
        }
    }
}
