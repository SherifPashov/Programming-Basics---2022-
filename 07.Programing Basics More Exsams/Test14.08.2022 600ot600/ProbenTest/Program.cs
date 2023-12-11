using System;

namespace ProbenTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int posledno = number % 10;
            Console.WriteLine(posledno);
        }
    }
}
