using System;

namespace _05._Pets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberDay = int.Parse(Console.ReadLine());
            int food = int.Parse(Console.ReadLine());
            double dogFoodForDay = double.Parse(Console.ReadLine());
            double catFoodForDay = double.Parse(Console.ReadLine());
            double turtleFoodForDay = double.Parse(Console.ReadLine());

            double foodForDog = dogFoodForDay * numberDay;
            double foodForCat = catFoodForDay * numberDay;
            double foodForTurtle = turtleFoodForDay * numberDay / 1000;

            double allFood = foodForDog + foodForCat + foodForTurtle;

            if (food >= allFood)
            {
                double def = food - allFood;
                Console.WriteLine($"{Math.Floor(def)} kilos of food left.");
            }
            else if (food < allFood)
            {
                double def = allFood - food;
                Console.WriteLine($"{Math.Ceiling(def)} more kilos of food are needed.");
            }
        }
    }
}
