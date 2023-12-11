using System;

namespace _10._Invalid_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int numbar = int.Parse(Console.ReadLine());

            if (numbar == 0)
            {
                Console.WriteLine("");
            }
            else if (numbar < 100 || numbar > 200)
            {
                Console.WriteLine("invalid");

            }
        }
    }
}
