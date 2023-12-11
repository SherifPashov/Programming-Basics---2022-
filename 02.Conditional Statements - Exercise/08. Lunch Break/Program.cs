using System;

namespace _08._Lunch_Break
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nameFilm = Console.ReadLine();
            double timeFilm = int.Parse(Console.ReadLine());
            double timeRest = int.Parse(Console.ReadLine());

            double lunch = timeRest / 8;
            double relax = timeRest / 4;

            double leftTime = timeRest - lunch - relax;
            double difference = Math.Abs(leftTime - timeFilm);
                difference = Math.Ceiling(difference);

            if (leftTime >= timeFilm )
            {
                Console.WriteLine($"You have enough time to watch {nameFilm} and left with {(difference)} minutes free time.");
            }
            else
            {
                Console.WriteLine($"You don't have enough time to watch {nameFilm}, you need {(difference)} more minutes.");
            }
            



        }
    }
}
