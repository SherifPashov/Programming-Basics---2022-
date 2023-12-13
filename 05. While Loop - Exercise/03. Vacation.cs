using System;

namespace _03._Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double needeMoney = double.Parse(Console.ReadLine());
            double moneyAll = double.Parse(Console.ReadLine());
            string operation = "";

            double money = 0; 
            int day = 1;
            int spendDay = 0;
            while (moneyAll < needeMoney)
            {
                operation = Console.ReadLine();
                money = double.Parse(Console.ReadLine());switch (operation)
                {
                    case "spend":
                        moneyAll -= money;
                        spendDay++;
                        if (moneyAll < 0 )
                        {
                            moneyAll = 0;
                        }
                        break;
                    case "save":
                        moneyAll += money;
                        spendDay = 0;
                        break;
                }
                if (spendDay == 5)
                {
                     Console.WriteLine($"You can't save the money.");
                     Console.WriteLine($"{day}");
                    break;
                }
                
                
                
                day++;
            }
            if (moneyAll >= needeMoney)
            {
                    Console.WriteLine($"You saved the money for {day - 1} days.");
                    
            }
            

        }
    }
}
