using System;

namespace _06._Max_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            
            int max = int.MinValue;
            while (number != "Stop")
            {
                int numberParse = int.Parse(number);
                if (numberParse > max )
                {
                    max = numberParse;
                }
                number = Console.ReadLine();
            }
            Console.WriteLine(max);
        }
    }
}
