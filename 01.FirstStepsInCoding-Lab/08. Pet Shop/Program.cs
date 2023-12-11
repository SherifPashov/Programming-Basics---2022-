using System;

namespace _08._Pet_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int namberpaketDog= int.Parse(Console.ReadLine());
            int namberPaketCat = int.Parse(Console.ReadLine());
            double paketDog = 2.5;
            double paketCat = 4;
            double priceCat = namberPaketCat * paketCat;
            double priceDog = namberpaketDog * paketDog;
            double price = priceCat + priceDog;
            Console.WriteLine($"{price} lv.");



        }
    }
}
