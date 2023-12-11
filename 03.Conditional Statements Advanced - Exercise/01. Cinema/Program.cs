using System;

namespace _01._Cinema
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string film = Console.ReadLine();
            int red = int.Parse(Console.ReadLine());
            int colona = int.Parse(Console.ReadLine());
            double price = 0;
            
            switch (film)
            {
                case "Premiere":
                    price = 12;
                    break;
                case "Normal":
                    price = 7.5;
                    break;
                case "Discount":
                    price = 5;
                    break;
            }
            int allPlaces = red * colona;
            double allPrice = allPlaces * price;
            Console.WriteLine($"{allPrice:f2} leva");

        }
    }
}
