using System;

namespace _05._Journey
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string destination = "";
            string hous = "";
            double price = 0;
            
            if (budget <=  100)
            {
                destination = "Bulgaria";
                switch (season)
                {
                    case "summer":
                        hous = "Camp";
                        price = 0.3 * budget;
                        break;
                    case "winter":
                        hous = "Hotel";
                        price = 0.7 * budget;
                        break;
                }

            }
            else if (budget <= 1000 )
            {
                destination = "Balkans";
                switch (season)
                {
                    case "summer":
                        hous = "Camp";
                        price = 0.4 * budget;
                        break;
                    case "winter":
                        hous = "Hotel";
                        price = 0.8 * budget;
                        break;
                }

            }
            else if (budget>1000)
            {
                destination = "Europe";
                hous = "Hotel";
                price = 0.9 * budget;
            }
            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"{ hous} - { price:f2}");





        }
    }
}
