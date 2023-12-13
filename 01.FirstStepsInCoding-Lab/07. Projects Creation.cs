using System;

namespace _07._Projects_Creation
{
    internal class Program
    {
        static void Main(string[] args)
        {
          string nameArchitect = Console.ReadLine();
            int namberProject =int.Parse(Console.ReadLine());
            int hour = namberProject * 3;
            Console.WriteLine($"The architect {nameArchitect} will need {hour} hours to complete {namberProject} project/s.");


        }
    }
}
