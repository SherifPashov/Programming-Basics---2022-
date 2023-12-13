using System;

namespace _06._Fishland
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double kgPriceSkumriq = double.Parse(Console.ReadLine());
            double kgPriceCaca = double.Parse(Console.ReadLine());
            double PricePalamud = double.Parse(Console.ReadLine());
            double PriceSafrid = double.Parse(Console.ReadLine());
            double PriceMidi = double.Parse(Console.ReadLine());

            double kgPriceMidi = 7.5;
            double kgPricePalamud = 1.6 * kgPriceSkumriq;
            double kgPriceSafrid = 1.8 * kgPriceCaca;

            double finishPricePalmud = kgPricePalamud * PricePalamud;
            double finishPriceSafrid = kgPriceSafrid * PriceSafrid;
            double finishPriceMidi = kgPriceMidi * PriceMidi;

            double finishPrice = finishPricePalmud + finishPriceSafrid + finishPriceMidi;

            Console.WriteLine($"{finishPrice:f2}");
        }
    }
}
