using System;

namespace _08._Fuel_Tank___Part_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string oil = Console.ReadLine();
            double quality = double.Parse(Console.ReadLine());
            string clubCard = Console.ReadLine();
            double price = 0;

            double gasoline = 2.22;
            double diesel = 2.33;
            double gas = 0.93;
            if (clubCard == "Yes")
            {
                gasoline -= 0.18;
                diesel -= 0.12;
                gas -= 0.08;
            }
            switch (oil)
            {

                case "Gasoline":
                    price = quality * gasoline;
                    break;
                case "Diesel":
                    price = quality * diesel;
                    break;
                case "Gas":
                    price = quality * gas;
                    break;
            }
            if (quality >= 20 && quality <= 25)
            {
                price *= 0.92;
            }
            else if (quality > 25)
            {
                price *= 0.9;
            }
            Console.WriteLine($"{price:f2} lv.");

        }
    }
}
