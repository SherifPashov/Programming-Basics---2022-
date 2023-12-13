using System;

namespace _07._Hotel_Room
{
    internal class Program
    {
        static void Main(string[] args)
        {
           string mounth = Console.ReadLine();
            int day = int.Parse(Console.ReadLine());
            
            double studio = 0;
            double apatrman = 0;

            switch (mounth)
            {
                case "May":
                case "October":
                    studio = 50;
                    apatrman = 65;
                    if (day > 7 && day <= 14)
                    {
                        studio = studio * 0.95;
                    }
                    else if (day > 14)
                    {
                        studio = studio * 0.7;
                    }
                    break;

                case "June":
                case "September":
                    studio = 75.2;
                    apatrman = 68.70;
                    if (day > 14)
                    {
                        studio = studio * 0.8;
                    }
                    break;

                case "July":
                case "August":
                    studio = 76;
                    apatrman = 77;
                    break;
            }
            if (day > 14)
            {
                apatrman = apatrman * 0.9;
            }
            double priceStudio = day * studio;
            double PriceApartman = day * apatrman;

            Console.WriteLine($"Apartment: {PriceApartman:f2} lv.");
            Console.WriteLine($"Studio: { priceStudio:f2} lv.");




        }
    }
}
