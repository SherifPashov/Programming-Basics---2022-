using System;

namespace _03._Harvest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            double z = double.Parse(Console.ReadLine());
            int numberPeople = int.Parse(Console.ReadLine());

            
            double grapes = x * y;
            double vino = grapes * 0.4 / 2.5;
            if (vino < z )
            {
                double def = z - vino;
                Console.WriteLine($"It will be a tough winter! More {Math.Floor(def)} liters wine needed.");
            }
            else if (vino >= z )
            {
                double def = vino - z;
                double literPeople = def / numberPeople;
                
                Console.WriteLine($"Good harvest this year! Total wine: {Math.Floor(vino)} liters.");
                Console.WriteLine($"{Math.Ceiling(def)} liters left -> {Math.Ceiling(literPeople)} liters per person.");
            }
            
        }
    }
}
