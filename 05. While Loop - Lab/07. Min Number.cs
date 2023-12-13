using System;

namespace _07._Min_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            int min = int.MaxValue;
            while (number != "Stop")
            {
                int numberParse = int.Parse(number);
                if (numberParse < min)
                {
                    min = numberParse;
                }
                number = Console.ReadLine();
            }
            Console.WriteLine(min);
        }
    }
}
