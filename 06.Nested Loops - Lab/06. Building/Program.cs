using System;

namespace _06._Building
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int etaj = int.Parse(Console.ReadLine());
            int rooms = int.Parse(Console.ReadLine());
            for (int i = etaj; i >= 1; i--)
            {
                for (int e = 0; e < rooms; e++)
                {
                    if (i == etaj)
                    {
                        Console.Write($"L{i}{e} ");
                    }
                    else if (i % 2 == 0 )
                    {
                        Console.Write($"O{i}{e} ");
                    }
                    else
                    {
                        Console.Write($"A{i}{e} ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
