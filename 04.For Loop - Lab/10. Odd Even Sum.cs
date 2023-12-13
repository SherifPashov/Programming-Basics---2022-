using System;

namespace _10._Odd_Even_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int sum1 = 0;
            int sum2 = 0;
            for (int i = 1; i <= number; i++)
            {
                int sumNumber = int.Parse(Console.ReadLine());
                if (i % 2 == 1)
                {
                    sum1 += sumNumber;
                }
                else if (i % 2 == 0)
                {
                    sum2 += sumNumber;
                }
            }
            if (sum1 == sum2)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {sum1}");
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {Math.Abs(sum1 - sum2)}");
            }


        }
    }
}
