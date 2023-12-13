using System;

namespace _01_AgencyProfit
{
    class Program
    {
        static void Main(string[] args)
        {
            string nameOfTheAircompany = Console.ReadLine();
            int ticketsForElder = int.Parse(Console.ReadLine());
            int ticketsForChildren = int.Parse(Console.ReadLine());
            double onlinePriceForTicketForElder = double.Parse(Console.ReadLine());
            double priceForService = double.Parse(Console.ReadLine());

            double onlinePriceForTicketForChildren = onlinePriceForTicketForElder - (0.7 * onlinePriceForTicketForElder);
            double priceForElderWithService = onlinePriceForTicketForElder + priceForService;
            double priceForChildrenService = onlinePriceForTicketForChildren + priceForService;

            double totalSumForTickets = (ticketsForChildren * priceForChildrenService) + (ticketsForElder * priceForElderWithService);


            double x = totalSumForTickets * 0.8;
            double profit = totalSumForTickets - x;

            Console.WriteLine($"The profit of your agency from {nameOfTheAircompany} tickets is {profit:F2} lv.");
        }
    }
}