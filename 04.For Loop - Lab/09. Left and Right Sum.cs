using System;

namespace _09._Left_and_Right_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int sumLeft = 0;
            int sumRight = 0;

            for (int i = 1; i <= number * 2; i++)
            {
                int numberSum = int.Parse(Console.ReadLine());
                if (i <= number)
                {
                    sumLeft += numberSum;
                }
                else if (i >= number)
                {
                    sumRight += numberSum;
                }
            }
            
            if (sumLeft == sumRight)
            {
                Console.WriteLine($"Yes, sum = {sumRight}");
            }
            else 
            {
                Console.WriteLine($"No, diff = {Math.Abs(sumLeft - sumRight)}");
            }


        }
    }
}
