using System;

namespace _03._New_House
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string flowers = Console.ReadLine();
            int numberFlowers = int.Parse(Console.ReadLine());
            double buget = double.Parse(Console.ReadLine());
            double priceOneFlowers = 0;
            double discount = 0;
            double finishPrice = 0;

            switch (flowers)
            {
                case "Roses":
                    priceOneFlowers = 5;
                    if (numberFlowers > 80)
                    {
                        discount = 0.9;
                    }
                    break;
                case "Dahlias":
                    priceOneFlowers = 3.8;
                    if (numberFlowers >90)
                    {
                        discount = 0.85;
                    }
                    break;
                case "Tulips":
                    priceOneFlowers = 2.8;
                    if (numberFlowers > 80)
                    {
                        discount = 0.85;
                    }
                    break;
                case "Narcissus":
                    priceOneFlowers = 3;
                    if (numberFlowers < 120)
                    {
                        discount = 1.15;
                    }
                    break;
                case "Gladiolus":
                    priceOneFlowers = 2.5;
                    if (numberFlowers < 80)
                    {
                        discount = 1.2;
                    }
                    break;

            }
            
            if (discount>0)
            {
                 finishPrice = priceOneFlowers * numberFlowers * discount;
            }
            else
            {
                 finishPrice = priceOneFlowers * numberFlowers ;
            }
            
            double diference = Math.Abs(finishPrice - buget);
            if (buget >= finishPrice)
            {
                Console.WriteLine($"Hey, you have a great garden with {numberFlowers} {flowers} and {diference:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money, you need {diference:f2} leva more.");
            }
        }
    }
}
