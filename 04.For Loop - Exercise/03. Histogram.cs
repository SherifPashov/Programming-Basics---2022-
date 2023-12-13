using System;

namespace _03._Histogram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int n1 = 0;
            int n2 = 0;
            int n3 = 0;
            int n4 = 0;
            int n5 = 0;
            for (int i = 0; i < number; i++)
            { 
                int volue = int.Parse(Console.ReadLine());

                if (volue < 200)
                {
                    n1++;
                }
                else if (volue >= 200 && volue < 400)
                {
                    n2++;
                }
                else if (volue >= 400 && volue < 600)
                {
                    n3++;
                }
                else if (volue >= 600 && volue <800)
                {
                    n4++;
                }
                else if (volue >= 800)
                {
                    n5++;
                }

            }

            double parcentN1 = n1 * 1.00 / number * 100;
            double parcentN2 = n2 * 1.00 / number * 100;
            double parcentN3 = n3 * 1.00 / number * 100;
            double parcentN4 = n4 * 1.00 / number * 100;
            double parcentN5 = n5 * 1.00 / number * 100;

            Console.WriteLine($"{parcentN1:f2}%");
            Console.WriteLine($"{parcentN2:f2}%");
            Console.WriteLine($"{parcentN3:f2}%");
            Console.WriteLine($"{parcentN4:f2}%");
            Console.WriteLine($"{parcentN5:f2}%");



        }
    }
}
