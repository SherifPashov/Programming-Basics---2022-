using System;

namespace _06._Repainting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double naylon = 1.5;
            double paint = 14.5;
            double razreditel = 5.00;

            double numbernaylon = double.Parse(Console.ReadLine());
            double numberPaint = double.Parse(Console.ReadLine());  
            double numberRazreditel = double.Parse(Console.ReadLine());
            double hour = double.Parse(Console.ReadLine());


            double priceNaylon = (numbernaylon+ 2) * naylon;
            double pricePaint = paint * numberPaint * 1.1;
            double priceRazreditel = razreditel * numberRazreditel;

            double priceMaterial = priceNaylon + pricePaint + priceRazreditel + 0.4;
            double priceForHour = (priceMaterial * 0.3) * hour;
            double finalPrice = priceMaterial + priceForHour;
            Console.WriteLine(finalPrice);





        }
    }
}
