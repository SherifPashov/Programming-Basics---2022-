using System;

namespace _09._Ski_Trip
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double day = int.Parse(Console.ReadLine());
            string hous = Console.ReadLine();
            string vote = Console.ReadLine();

            double room = 18;
            double apartment = 25;
            double president = 35;
            double price = 0;

            if (day < 10)
            {
                switch (hous)
                {
                    case "room for one person":
                        price = (day-1) * room;
                        break;
                    case "apartment":
                        price = (day - 1) * apartment * 0.7;
                        break;
                    case "president apartment":
                        price = (day - 1) * president * 0.9;
                        break;
                }

            }
            else if (day >=10 && day <= 15)
            {
                switch (hous)
                {
                    case "room for one person":
                        price = (day - 1) * room;
                        break;
                    case "apartment":
                        price = (day - 1) * apartment * 0.65;
                        break;
                    case "president apartment":
                        price = (day - 1) * president * 0.85;
                        break;
                }
            }
            else if (day > 15)
            {
                switch (hous)
                {
                    case "room for one person":
                        price = (day - 1) * room;
                        break;
                    case "apartment":
                        price = (day - 1) * apartment * 0.5;
                        break;
                    case "president apartment":
                        price = (day - 1) * president * 0.8;
                        break;
                }
            }
            if (vote == "positive")
            {
                price = price * 1.25;
            }
            else if (vote == "negative")
            {
                price = price * 0.9;
            }
            Console.WriteLine($"{price:f2}");
            

        }
    }
}
