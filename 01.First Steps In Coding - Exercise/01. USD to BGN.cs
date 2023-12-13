using System;

namespace _01._USD_to_BGN
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            double bgn = double.Parse(Console.ReadLine());
            double usd = 1.79549;
            double usdToBgn = usd * bgn;
            Console.WriteLine(usdToBgn);




           
        }
    }
}
