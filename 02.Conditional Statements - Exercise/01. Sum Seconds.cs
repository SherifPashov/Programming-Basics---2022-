using System;

namespace _01._Sum_Seconds
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int firstTime = int.Parse(Console.ReadLine());
            int secondTime = int.Parse(Console.ReadLine());
            int trirdTime = int.Parse(Console.ReadLine());

            int totalTime = firstTime + secondTime + trirdTime;

            int minutes = totalTime / 60;
            int seconds = totalTime % 60;
            Console.WriteLine($"{minutes}:{seconds:d2}");

        }
    }
}
