using System;

namespace _02._Sleepy_Tom_Cat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberWeekend = int.Parse(Console.ReadLine());


            int numberWorckingDay = 365 - numberWeekend;
            int playTime = (numberWorckingDay * 63) + (numberWeekend * 127);

            if (playTime > 30000)
            {
                double def = playTime - 30000;
                double hours =Math.Floor( def / 60);
                double minutes = Math.Floor( def % 60);

                Console.WriteLine($"Tom will run away");
                Console.WriteLine($"{hours} hours and {minutes} minutes more for play");
            }
            else if (playTime < 30000)
            {
                double def = 30000 - playTime;
                double hours = Math.Floor(def / 60);
                double minutes = Math.Floor(def % 60);

                Console.WriteLine($"Tom sleeps well");
                Console.WriteLine($"{hours} hours and {minutes} minutes less for play");
            }
        }
    }
}
