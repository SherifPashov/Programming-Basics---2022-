using System;

namespace _04._Clever_Lily
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double priceForPeralnq = double.Parse(Console.ReadLine());
            double priceForToy = double.Parse(Console.ReadLine());
            double allPrice = 0;
            for (int i = 1; i <= age; i++)
            {
                if (i % 2 == 1)
                {
                    allPrice += priceForToy;
                    
                }
                else if (i % 2 == 0)
                {
                    allPrice += 10 * i / 2;
                    allPrice -= 1;
                }

            }
            

            if (allPrice >= priceForPeralnq)
            {
                Console.WriteLine($"Yes! {(allPrice - priceForPeralnq):f2}") ;
            }
            else if (allPrice < priceForPeralnq)
            {
                double price = priceForPeralnq - allPrice;
                Console.WriteLine($"No! {price:f2}");
            }
               
        }
    }
}
