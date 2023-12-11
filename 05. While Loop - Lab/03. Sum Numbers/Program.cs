using System;

namespace _03._Sum_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int numberSum = int.Parse(Console.ReadLine());
            int sum = 0;
            while (number > sum)
            {
                sum += numberSum;
                if (sum >= number)
                {
                    break;
                }
                numberSum = int.Parse(Console.ReadLine());
            }
            Console.WriteLine(sum);
        }
    }
}
