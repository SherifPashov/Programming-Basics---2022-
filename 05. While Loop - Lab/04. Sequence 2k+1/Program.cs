using System;

namespace _04._Sequence_2k_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int number2k = 1;

            while (number >= number2k)
            {
                Console.WriteLine(number2k);
                number2k = number2k * 2 + 1;
            }

        }
    }
}
