using System;

namespace _05.TravellingOriginal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string destination = Console.ReadLine();

            while (destination != "End")
            {
                double minimalBudget = double.Parse(Console.ReadLine());
                double savingSum = 0;

                while (savingSum < minimalBudget)
                {
                    double saving = double.Parse(Console.ReadLine());
                    savingSum += saving;
                }
                Console.WriteLine($"Going to {destination}!");

                destination = Console.ReadLine();
            }

        }
    }
}
