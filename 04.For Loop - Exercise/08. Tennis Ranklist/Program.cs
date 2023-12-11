using System;

namespace _08._Tennis_Ranklist
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberTurnir = int.Parse(Console.ReadLine());
            int startPoints = int.Parse(Console.ReadLine());
            int points = 0;
            double win = 0;
            
            for (int i = 0; i < numberTurnir; i++)
            {
                string etap = Console.ReadLine();

                switch (etap)
                {
                    case "W":
                        points += 2000;
                        win++;
                        break;
                    case "F":
                        points += 1200;
                        break;
                    case "SF":
                        points += 720;
                        break;
                }
            }
            double averagePoint = points / numberTurnir; 
            double winParcent = win / numberTurnir * 100;
            Console.WriteLine($"Final points: {points + startPoints}");
            Console.WriteLine($"Average points: {averagePoint}");
            Console.WriteLine($"{winParcent:f2}%");
        }
    }
}
