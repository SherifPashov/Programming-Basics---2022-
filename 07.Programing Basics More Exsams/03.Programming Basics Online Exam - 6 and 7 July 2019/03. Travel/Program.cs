using System;

namespace _03._Travel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string city = Console.ReadLine();
            string packet = Console.ReadLine();
            string VIP = Console.ReadLine();
            int numberDay = int.Parse(Console.ReadLine());
            double priceForOneDay = 0;

            

            if (city == "Bansko" || city == "Borovets")
            {
                switch (packet)
                {
                    case "noEquipment":
                        priceForOneDay = 80;
                        break;
                    case "withEquipment":
                        priceForOneDay = 100;
                        break;
                    default:
                        Console.WriteLine("Invalid input!");
                        break;
                }
                if (packet != "noEquipment" && packet!= "withEquipment")
                {
                    Console.WriteLine("Invalid input!");
                }
            }
            else if (city == "Varna" || city == "Burgas")
            {
                switch (packet)
                {

                    case "noBreakfast":
                        priceForOneDay = 100;
                        break;
                    case "withBreakfast":
                        priceForOneDay = 130;
                        break;
                    default:
                        Console.WriteLine("Invalid input!");
                        break;
                }
                if (packet != "noBreakfast" && packet != "withBreakfast")
                {
                    Console.WriteLine("Invalid input!");
                }
            }
            else 
            {
                Console.WriteLine("Invalid input!");
            }

            
            if (VIP == "yes")
            {
                switch (packet)
                {
                    case "noEquipment":
                        priceForOneDay *= 0.95;
                        break;
                    case "withEquipment":
                        priceForOneDay *= 0.9;
                        break;
                    case "noBreakfast":
                        priceForOneDay *= 0.93;
                        break;
                    case "withBreakfast":
                        priceForOneDay *= 0.88;
                        break;
                    default:
                        Console.WriteLine("Invalid input!");
                        break;
                }
            }

            if (numberDay < 1)
            {
                Console.WriteLine("Days must be positive number!");
            }
            double finishPrice = numberDay * priceForOneDay;
            if (finishPrice > 0)
            {
                Console.WriteLine($"The price is {finishPrice:f2}lv! Have a nice time!");
            }
        }
    }
}
