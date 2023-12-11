using System;

namespace _03._Final_Competition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberPeople = int.Parse(Console.ReadLine());
            double points = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string mqsto = Console.ReadLine();

            double price = 0;

            switch (mqsto)
            {
                case "Bulgaria":
                    price = numberPeople * points;
                    switch (season)
                    {
                        case "summer":
                            price *= 0.95;
                            break;
                        case "winter":
                            price *= 0.92;
                            break;
                    }
                    break;
                default:
                    double firstPrice = numberPeople * points;
                    price = firstPrice * 1.5;
                    switch (season)
                    {
                        case "summer":
                            price *= 0.9;
                            break;
                        case "winter":
                            price *= 0.85;
                            break;
                    }
                    break;
            }

            double blagotvoritelnost = price * 0.75;
            price = price - blagotvoritelnost;
            double moneyForOnePeople = price / numberPeople;
            Console.WriteLine($"Charity - { blagotvoritelnost:f2}");
            Console.WriteLine($"Money per dancer - {moneyForOnePeople:f2}");
        }   
    }
}
