using System;

namespace _02._Deer_of_Santa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberDay = int.Parse(Console.ReadLine());
            int foodKg = int.Parse(Console.ReadLine());
            double oneFood = double.Parse(Console.ReadLine());
            double twoFood = double.Parse(Console.ReadLine());
            double treeFood = double.Parse(Console.ReadLine());

            double foodOneDay = oneFood + twoFood + treeFood;
            double foodForAllDay = numberDay * foodOneDay;

            if (foodKg >= foodForAllDay )
            {
                double def = Math.Floor(foodKg - foodForAllDay);

                Console.WriteLine($"{def} kilos of food left.");

            }
            else if (foodKg < foodForAllDay)
            {
                double def = Math.Ceiling(foodForAllDay - foodKg);
                Console.WriteLine($"{def} more kilos of food are needed.");
            }
        }
    }
}
