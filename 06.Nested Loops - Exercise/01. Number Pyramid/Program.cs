using System;

namespace _01._Number_Pyramid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int number = 1;
            for (int row = 1; row <= input; row++)
            {
                for (int i = 1; i <= row; i++)
                {
                    Console.Write($"{number} ");
                    number++;
                    if (number > input)
                    {
                        break;
                    }

                }
                Console.WriteLine();
                if (number > input)
                {
                    break;
                }
            }
        }
    }
}
