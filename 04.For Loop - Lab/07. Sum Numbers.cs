using System;

namespace _07._Sum_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 0; i < number; i++)
            {
                int sumNumber = int.Parse(Console.ReadLine());
                sum += sumNumber;

            }
            Console.WriteLine(sum);
        }
    }
}
