using System;

namespace _04._Toy_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
          double priceForExcursion = double.Parse(Console.ReadLine());
            int numberPuzzeles = int.Parse(Console.ReadLine());
            int numberDolls = int.Parse(Console.ReadLine());
            int numberBear = int.Parse(Console.ReadLine());
            int numberMinion = int.Parse(Console.ReadLine());
            int numberTruck = int.Parse(Console.ReadLine());

            double pricePuzzeles = numberPuzzeles * 2.6;
            double priceDolls = numberDolls * 3.0 ;
            double priceBear = numberBear * 4.10;
            double priceMinion = numberMinion * 8.20;
            double priceTruck = numberTruck * 2.0;

            double priceForAllToys = pricePuzzeles + priceDolls + priceBear + priceMinion + priceTruck;
            double numberForAllToys = numberPuzzeles + numberDolls + numberBear + numberMinion + numberTruck;

            if (numberForAllToys >= 50 )
            {
                priceForAllToys = priceForAllToys * 0.75;
            }
            
            priceForAllToys = priceForAllToys * 0.9;

            if (priceForAllToys >= priceForExcursion)
            {
                double remainder = Math.Abs(priceForAllToys - priceForExcursion);
                Console.WriteLine($"Yes! {remainder:f2} lv left.");
            }
            else
            {
                double lack = Math.Abs(priceForAllToys - priceForExcursion);
                Console.WriteLine($"Not enough money! {lack:f2} lv needed.");
            }

        }
    }
}
