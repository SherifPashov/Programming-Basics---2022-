using System;

namespace _04._Transport_Price
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string word = Console.ReadLine();
            double price = 0;
            if (n >= 20 && n < 100)
            {
                //avtobus
                price = n * 0.09;

            }
            else if (n >= 100)
            {
                //vlak
                price = n * 0.06;
                
            }
            else if (n < 20)
            {
                // taxi
                if (word == "day")
                {
                    price = n * 0.79 + 0.7;

                }
                else if (word == "night")
                {
                    price = n * 0.9 + 0.7;
                }
            }
            Console.WriteLine($"{price:f2}");



        }
    }
}
