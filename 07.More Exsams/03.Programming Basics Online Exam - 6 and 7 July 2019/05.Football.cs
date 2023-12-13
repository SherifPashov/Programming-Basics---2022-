using System;

namespace _05.Football
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nameFootball = Console.ReadLine();
            int numberMatch = int.Parse(Console.ReadLine());

            int w = 0;
            int d = 0;
            int l = 0;
            int points = 0;

            if (numberMatch == 0 )
            {
                Console.WriteLine($"{nameFootball} hasn't played any games during this season.");
            }

            for (int i = 0; i < numberMatch; i++)
            {
                string result = Console.ReadLine();
                switch (result)
                {
                    case "W":
                        points += 3;
                        w++;
                        break;
                    case "D":
                        points ++;
                        d++;
                        break;
                    case "L":
                        l++;
                        break;
                }
            }
            if (numberMatch > 0)
            {
                double winRate = w * 100.0 / numberMatch;
                Console.WriteLine($"{nameFootball} has won {points} points during this season.");
                Console.WriteLine("Total stats:");
                Console.WriteLine($"## W: {w}");
                Console.WriteLine($"## D: {d}");
                Console.WriteLine($"## L: {l}");
                Console.WriteLine($"Win rate: {winRate:f2}%");


            }
        }
    }
}
