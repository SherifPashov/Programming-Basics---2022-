using System;

namespace _04._Sum_of_Two_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());

            int magicNumber = int.Parse(Console.ReadLine());
            int combination = 0;
            int first =0;
            int second = 0;

            for (int i = start; i <= end; i++)
            {
                first = i;
                for (int j = start; j <= end; j++)
                {
                    second = j;
                    combination++;

                    if (i + j == magicNumber)
                    {
                        Console.WriteLine($"Combination N:{combination} ({i} + {j} = {magicNumber})");
                        break;
                    }
                }
                if (i + second == magicNumber)
                {
                    break;
                }
            }
            if (first + second != magicNumber)
            {
                    Console.WriteLine($"{combination} combinations - neither equals {magicNumber}");
            }
        }
    }
}
