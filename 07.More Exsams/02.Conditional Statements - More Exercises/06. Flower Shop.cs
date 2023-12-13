using System;

namespace _06._Flower_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberMangolii = int.Parse(Console.ReadLine());
            int numberZumbuli = int.Parse(Console.ReadLine());
            int numberRose = int.Parse(Console.ReadLine());
            int numberKaktus = int.Parse(Console.ReadLine());
            double priceForGift = double.Parse(Console.ReadLine());

            double allPriceMongolii = numberMangolii * 3.25;
            double allPriceZumbuli = numberZumbuli * 4;
            double allPriceRose = numberRose * 3.5;
            double allPriceKaktusi = numberKaktus * 8;

            double sum = allPriceMongolii + allPriceZumbuli + allPriceRose + allPriceKaktusi;
            double tax = sum * 0.95;
            if (tax >= priceForGift)
            {
                double def = tax - priceForGift;
                Console.WriteLine($"She is left with {Math.Floor(def)} leva.");
            }
            else if (tax < priceForGift)
            {
                double def = priceForGift - tax;
                Console.WriteLine($"She will have to borrow {Math.Ceiling(def)} leva.");
            }

        }
    }
}
