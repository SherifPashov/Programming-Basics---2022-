using System;

namespace _05._Supplies_for_School
{
    internal class Program
    {
        static void Main(string[] args)
        {
          double pens = 5.80;
          double marker = 7.2;
          double preparat = 1.2;

          double numberPens = double.Parse(Console.ReadLine());
          double numberMarker = double.Parse(Console.ReadLine());
          double numberPreparat= double.Parse(Console.ReadLine());
          double percent = double.Parse(Console.ReadLine());

            double percentFinish = percent / 100;
            double pricePens = pens * numberPens;
            double priceMarker = marker * numberMarker; 
            double pricePreparat = preparat * numberPreparat;
            double price = pricePens + priceMarker + pricePreparat;
            double finalPrice = price - (price * percentFinish );

            Console.WriteLine(finalPrice);






        }
    }
}
