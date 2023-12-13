using System;

namespace _07._Food_Delivery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double menuChicken = 10.35;
           double menuFish = 12.40;
            double menuVegan = 8.15;

            double numberChickenMenu = double.Parse(Console.ReadLine());
            double numberFishMenu = double.Parse(Console.ReadLine());
            double numberVeganMenu = double.Parse(Console.ReadLine());

            double priceChickenMenu = numberChickenMenu * menuChicken;
            double priceFishMenu = numberFishMenu * menuFish;
            double priceVeganMenu = numberVeganMenu * menuVegan;

            double priceMenu = priceChickenMenu + priceFishMenu + priceVeganMenu;
            double priceDesert = priceMenu * 0.2;
            double finalPrice = priceMenu + priceDesert + 2.5;
            Console.WriteLine(finalPrice);


        }
    }
}
