using System;

namespace _12._Trade_Commissions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string city = Console.ReadLine();
            double price = double.Parse(Console.ReadLine());
            double commissions = 0;
            if (price >= 0 && price <=500 )
            {
                switch (city)
                {
                    case "Sofia":
                        commissions = price * 0.05;
                        break;
                    case "Varna":
                        commissions = price * 0.045;
                        break;
                    case "Plovdiv":
                        commissions = price * 0.055;
                        break;
                }
                

            }
            else if (price > 500 && price <= 1000)
            {
                switch (city)
                {
                    case "Sofia":
                        commissions = price * 0.07;
                        break;
                    case "Varna":
                        commissions = price * 0.075;
                        break;
                    case "Plovdiv":
                        commissions = price * 0.08;
                        break;
                }
                

            }
            else if (price >1000 && price <= 10000)
            {
                switch (city)
                {
                    case "Sofia":
                        commissions = price * 0.08;
                        break;
                    case "Varna":
                        commissions = price * 0.10;
                        break;
                    case "Plovdiv":
                        commissions = price * 0.12;
                        break;
                }
                
            }
            else if (price > 10000)
            {
                switch (city)
                {
                    case "Sofia":
                        commissions = price * 0.12;
                        break;
                    case "Varna":
                        commissions = price * 0.13;
                        break;
                    case "Plovdiv":
                        commissions = price * 0.145;
                        break;
                }
                
            }
            
            if (commissions > 0)
            {
                Console.WriteLine($"{commissions:F2}");
            }
            else 
            {
                Console.WriteLine("error");
            }






        }
    }
}
