using System;

namespace _08._Number_sequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int max = int.MinValue;
            int min = int.MaxValue;

            for (int i = 0; i < number; i++)
            {
                int numberAll = int.Parse(Console.ReadLine());
                if (numberAll > max)
                {
                    max = numberAll;
                }
                
                if (numberAll < min )
                {
                    min = numberAll;
                }
                
            }
            Console.WriteLine($"Max number: {max}");
            Console.WriteLine($"Min number: {min}");
        }
    }
}
