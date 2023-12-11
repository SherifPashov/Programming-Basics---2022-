using System;

namespace _10._Weather_Forecast___Part_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double vreme = double.Parse(Console.ReadLine());
            if (vreme >= 5 && vreme <= 12.9)
            {
                Console.WriteLine("Cold");
            }
            else if (vreme >= 12 && vreme <= 14.9)
            {
                Console.WriteLine("Cool");
            }
            else if (vreme >= 15 && vreme <= 20)
            {
                Console.WriteLine("Mild");
            }
            else if (vreme >= 20.1 && vreme <= 25.9)
            {
                Console.WriteLine("Warm");
            }
            else if (vreme >= 26 && vreme <= 35)
            {
                Console.WriteLine("Hot");
            }
            else
            {
                Console.WriteLine("unknown");
            }
        }
    }
}
