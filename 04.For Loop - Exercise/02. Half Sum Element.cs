using System;

namespace _02._Half_Sum_Element
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int sum = 0;
            
            int max = int.MinValue;
            for (int i = 0; i < number; i++)
            {
               int numberSum = int.Parse(Console.ReadLine());
                sum += numberSum;
                if (max < numberSum)
                {
                    max = numberSum;
                }

            }
            if (max == sum - max)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {max}");
            }
            else
            {
                int differece = sum - max;
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {Math.Abs(max -differece)}");
            }
        }
    }
}
