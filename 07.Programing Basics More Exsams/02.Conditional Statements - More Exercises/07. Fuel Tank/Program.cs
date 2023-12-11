using System;

namespace _07._Fuel_Tank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string oil = Console.ReadLine();
            double liters = double.Parse(Console.ReadLine());
            switch (oil)
            {
                case "Diesel":
                case "Gasoline":
                case "Gas":
                    if (liters >= 25 )
                    {
                       Console.WriteLine($"You have enough {oil.ToLower()}.");
                    }
                    else if (liters < 25 )
                    {
                       Console.WriteLine($"Fill your tank with {oil.ToLower()}!");
                    }
                    break;
                default:
                    Console.WriteLine("Invalid fuel!");
                    break;
            }
            
        }
    }
}
