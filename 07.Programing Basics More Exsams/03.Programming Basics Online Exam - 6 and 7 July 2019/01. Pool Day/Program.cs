using System;

namespace _01._Pool_Day
{
    internal class Program
    {
        static void Main(string[] args)
        {


            int numberPeople = int.Parse(Console.ReadLine());
            double taxsaG0 = double.Parse(Console.ReadLine());
            double priceShezlong = double.Parse(Console.ReadLine());
            double priceChedar = double.Parse(Console.ReadLine());


            double priceGo = numberPeople * taxsaG0;
            double numberPeopleShezlong = Math.Ceiling(numberPeople * 0.75);
            double allPriceShezlong = priceShezlong * numberPeopleShezlong;
            double numberPeopleChadar = Math.Ceiling(numberPeople * 0.5);
            double allPriceChedar = priceChedar * numberPeopleChadar;

            double allPrice = priceGo + allPriceShezlong + allPriceChedar;
            Console.WriteLine($"{allPrice:f2} lv.");
        }
    }
}
