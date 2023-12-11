using System;

namespace _05._Godzilla_vs._Kong
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budgetFilm = double.Parse(Console.ReadLine());
            int numberStatist = int.Parse(Console.ReadLine());
            double priceForClothing1 = double.Parse(Console.ReadLine());
            
            double decor = budgetFilm * 0.1;

            double priceForAllClothing = 0;
           

            if (numberStatist > 150 )
            {
                priceForAllClothing = numberStatist * (priceForClothing1 * 0.9);

            }
            else
            {
                priceForAllClothing = numberStatist * priceForClothing1;
            }
            
            double priceFilm = decor + priceForAllClothing;
            
            double priceBudget = Math.Abs(priceFilm - budgetFilm);

            if (priceFilm > budgetFilm)
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {priceBudget:f2} leva more.");

            }
            else
            {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {priceBudget:f2} leva left.");

            }






        }
    }
}
