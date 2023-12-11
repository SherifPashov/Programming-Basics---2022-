using System;

namespace _02._Family
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int numberNight = int.Parse(Console.ReadLine());
            double priceForOneNight = double.Parse(Console.ReadLine());
            int parcent = int.Parse(Console.ReadLine());

            if (numberNight > 7)
            {
                priceForOneNight *= 0.95;
            }
            double priceNight = priceForOneNight * numberNight;
            double parcentCalcolate = parcent * budget / 100;
            double finishPrice = priceNight + parcentCalcolate;
            double def = Math.Abs(budget - finishPrice);
            if (budget >= finishPrice)
            {
                
                Console.WriteLine($"Ivanovi will be left with {def:f2} leva after vacation.");
            }
            else if (budget < finishPrice)
            {
                Console.WriteLine($"{def:f2} leva needed.");
            }
        }
    }
}
