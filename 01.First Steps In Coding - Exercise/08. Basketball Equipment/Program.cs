using System;

namespace _08._Basketball_Equipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double fee = double.Parse(Console.ReadLine());

            double priceShoes = fee * 0.6;
            double priceClothes = priceShoes * 0.8;
            double priceBall = priceClothes / 4;
            double priceAccessories = priceBall / 5;

            double finalPrice = fee + priceShoes + priceClothes + priceBall + priceAccessories;
            Console.WriteLine(finalPrice);



        }
    }
}
