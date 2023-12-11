using System;

namespace _04._Club
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double pechalba = double.Parse(Console.ReadLine());
            string kokteil = Console.ReadLine();
            
            double finishprice = 0;
            while (kokteil != "Party!")
            {
                double priceForOnePorachka = 0;
                double priceForOneKokteil = kokteil.Length;
                int numberKokteil = int.Parse(Console.ReadLine());
                priceForOnePorachka = priceForOneKokteil * numberKokteil;
                if (priceForOnePorachka % 2 == 1)
                {
                    priceForOnePorachka *= 0.75;
                }
                
                finishprice += priceForOnePorachka;
                if (finishprice >= pechalba )
                {
                    Console.WriteLine("Target acquired.");
                    break;
                }

                kokteil = Console.ReadLine();
            }
            if (finishprice < pechalba)
            {
                double def = pechalba - finishprice;
                Console.WriteLine($"We need {def:f2} leva more.");
            }
            
                
                Console.WriteLine($"Club income - {finishprice:f2} leva.");
            
        }
    }
}
