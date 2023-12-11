using System;

namespace _06._Oscars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            double points = double.Parse(Console.ReadLine());
            int numberJury = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberJury; i++)
            {
                string nameJury = Console.ReadLine();
                int n1 = nameJury.Length;
                double pointJuri = double.Parse(Console.ReadLine());
                points += n1 * pointJuri / 2;
                if (points > 1250.50)
                {
                    Console.WriteLine($"Congratulations, {name} got a nominee for leading role with {points}!");
                    break;
                }
            }
            if (points < 1250.50)
            {
                double deff = 1250.50 - points;
                Console.WriteLine($"Sorry, {name} you need {deff:f1} more!");
            }


        }
    }
}
