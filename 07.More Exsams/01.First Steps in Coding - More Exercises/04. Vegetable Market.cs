using System;

namespace _04._Vegetable_Market
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double priceVegitable = double.Parse(Console.ReadLine());
            double priceFruit = double.Parse(Console.ReadLine());
            double kgVegitable = double.Parse(Console.ReadLine());
            double kgFruit = double.Parse(Console.ReadLine());

            double allPriceVefitable = priceVegitable * kgVegitable;
            double allPriceFruit = priceFruit * kgFruit;

            double price = allPriceVefitable + allPriceFruit;
            double evroPrice = price / 1.94;

            Console.WriteLine($"{evroPrice:f2}");
        }
    }
}
