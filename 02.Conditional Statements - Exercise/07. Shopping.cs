using System;

namespace _07._Shopping
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budgetPetar = double.Parse(Console.ReadLine());
            int numberVideocard = int.Parse(Console.ReadLine());
            int numberProcesor = int.Parse(Console.ReadLine());
            int numberRam = int.Parse(Console.ReadLine());

            double priceForVideocard = numberVideocard * 250;
            double priceForProcesor = (priceForVideocard * 0.35) * numberProcesor;
            double priceForRam = (priceForVideocard * 0.1) * numberRam;

            double allPrice = priceForVideocard + priceForProcesor + priceForRam ;
            
            if (numberVideocard > numberProcesor)
            {
                allPrice *= 0.85;
            }
            
            double diferance = Math.Abs(budgetPetar - allPrice);
            
            if (budgetPetar < allPrice)
            {
              Console.WriteLine($"Not enough money! You need {diferance:f2} leva more!");       
            }
            else
            { Console.WriteLine($"You have {diferance:f2} leva left!");
                 
            }




        }
    }
}
