using System;

namespace _04._Even_Powers_of_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = 1;
            for (int value = 0; value <= n1; value+=2)
            {
                Console.WriteLine(n2);
                n2 *= 2 * 2;
            }

        }
    }
}
