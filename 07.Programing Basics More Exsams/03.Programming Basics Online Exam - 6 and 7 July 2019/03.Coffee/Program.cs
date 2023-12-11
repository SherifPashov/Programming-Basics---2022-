using System;

namespace _03.Coffee
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string napitka = Console.ReadLine();
            string shugar = Console.ReadLine();
            int numbernapitka = int.Parse(Console.ReadLine());
            double priceSingle = 0;

            switch (shugar)
            {
                case "Without":
                    switch (napitka)
                    {
                        case "Espresso":
                            priceSingle = 0.9 * 0.65;
                            if (numbernapitka >= 5)
                            {
                                priceSingle *= 0.75;
                            }
                            break;
                        case "Cappuccino":
                            priceSingle = 1 * 0.65;
                            break;
                        case "Tea":
                            priceSingle = 0.5 * 0.65;
                            break;
                    }
                    break;
                case "Normal":
                    switch (napitka)
                    {
                        case "Espresso":
                            priceSingle = 1;
                            if (numbernapitka >= 5)
                            {
                                priceSingle *= 0.75;
                            }
                            break;
                        case "Cappuccino":
                            priceSingle = 1.2;
                            break;
                        case "Tea":
                            priceSingle = 0.6;
                            break;
                    }
                    break;
                case "Extra":
                    switch (napitka)
                    {
                        case "Espresso":
                            priceSingle = 1.2;
                            if (numbernapitka >= 5)
                            {
                                priceSingle *= 0.75;
                            }
                            break;
                        case "Cappuccino":
                            priceSingle = 1.6;
                            break;
                        case "Tea":
                            priceSingle =0.7;
                            break;
                    }
                    break;

            }
            double finishPrice = numbernapitka * priceSingle;
            if (finishPrice > 15)
            {
                finishPrice *= 0.8;
            }
            Console.WriteLine($"You bought {numbernapitka} cups of {napitka} for {finishPrice:f2} lv.");
        }
    }
}
