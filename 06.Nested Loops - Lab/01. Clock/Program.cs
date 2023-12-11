using System;

namespace _01._Clock
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int hours = 0; hours < 24; hours++)
            {
                for (int minute = 0; minute < 60; minute++)
                {
                    Console.WriteLine($"{hours}:{minute}");
                }
            }
        }
    }
}
