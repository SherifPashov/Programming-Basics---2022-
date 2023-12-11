using System;

namespace _04._Inches_to_Centimeters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double inch = 2.54;
            double sm = double.Parse(Console.ReadLine());
            double incToSm = inch * sm;
            Console.WriteLine(incToSm);
        }
    }
}
