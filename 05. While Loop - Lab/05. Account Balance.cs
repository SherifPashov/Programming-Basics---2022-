using System;

namespace _05._Account_Balance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fond = Console.ReadLine();
            double sum = 0;
            double number = 0;

            while (fond != "NoMoreMoney")
            {
                 number = double.Parse(fond);
                sum += number;
                if (number < 0)
                {
                    Console.WriteLine($"Invalid operation!");
                    Console.WriteLine($"Total: {(sum- number):f2}");
                    break;
                }
                Console.WriteLine($"Increase: {number:f2}");
                fond = Console.ReadLine();
                
            }
            if (number > 0)
            {
                Console.WriteLine($"Total: {sum:f2}");
            }
            
        }
    }
}
