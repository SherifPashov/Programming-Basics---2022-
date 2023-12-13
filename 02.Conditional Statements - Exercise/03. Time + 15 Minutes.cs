using System;

namespace _03._Time___15_Minutes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            int nextMinutes = minutes + 15;
            
            if (nextMinutes >= 60 )
            {
                nextMinutes = nextMinutes - 60;
                hours = hours + 1;
            }
            if (hours == 24)
            {
                hours = 0;
            }
            Console.WriteLine($"{(hours)}:{nextMinutes:d2}");


        }
    }
}
