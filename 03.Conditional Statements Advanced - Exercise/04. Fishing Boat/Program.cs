using System;

namespace _04._Fishing_Boat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            double number = double.Parse(Console.ReadLine());
            
            
           double priceBoat = 0;

            switch (season)
            {
                case "Spring":
                    
                    if (number <= 6)
                    {
                        priceBoat = 3000 * 0.9 ;
                    }
                    else if (number >= 7 && number <= 11)
                    {
                        priceBoat = 3000 * 0.85;
                    }
                    else if (number > 12)
                    {
                        priceBoat = 3000 * 0.75 ;
                    }
                      
                    break;
                case "Summer":
                    
                    if (number <= 6)
                    {
                        priceBoat = 4200 * 0.9;
                    }
                    else if (number >= 7 && number <= 11)
                    {
                        priceBoat = 4200 * 0.85;
                    }
                    else if (number > 12)
                    {
                        priceBoat = 4200 * 0.75;
                    }
                    break;
                    
                case "Autumn":
                    
                    if (number <= 6)
                    {
                        priceBoat = 4200 * 0.9;
                    }
                    else if (number >= 7 && number <= 11)
                    {
                        priceBoat = 4200 * 0.85;
                    }
                    else if (number > 12)
                    {
                        priceBoat = 4200 * 0.75;
                    }
                    break;
                case "Winter":
                    
                    if (number <= 6)
                    {
                        priceBoat = 2600 * 0.9;
                    }
                    else if (number >= 7 && number <= 11)
                    {
                        priceBoat = 2600 * 0.85;
                    }
                    else if (number > 12)
                    {
                        priceBoat = 2600 * 0.75;
                    }
                    break;
                    
            }
            if (number % 2 == 0 && season != "Autumn")
            {
                priceBoat = priceBoat * 0.95;
            }
            double diference = Math.Abs(budget - priceBoat);
               if (budget >= priceBoat)
               {
                   Console.WriteLine($"Yes! You have {diference:f2} leva left.");
               }
               else if (budget< priceBoat)
               {
                 Console.WriteLine($"Not enough money! You need {diference:f2} leva.");
               }

                    //4300
                    //Spring
                    //11
                    //Yes! You have 1750.00 leva left.

        }
    }
}
