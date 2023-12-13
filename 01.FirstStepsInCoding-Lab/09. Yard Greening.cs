using System;

namespace _09._Yard_Greening
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double pricem2 = 7.61;
            double m2 = double.Parse(Console.ReadLine());
            double price = pricem2 * m2;
            double discount = price * 0.18;
            double finalPrice = price - discount;
            //print
            Console.WriteLine($"The final price is: {finalPrice} lv.");
            Console.WriteLine($"The discount is: {discount} lv.");





        }
    }
}
