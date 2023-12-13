using System;

namespace _11._Fruit_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine();
            string day = Console.ReadLine();
            double number = double.Parse(Console.ReadLine());
            double price = 0;
            switch (day)
            {
                case "Monday":
                case "Tuesday":
                case "Wednesday":
                case "Thursday":
                case "Friday":
                    switch (fruit)
                    {
                        case "banana":
                            price = number * 2.5 ;
                            break;
                        case "apple":
                            price = number * 1.2;
                            break;
                        case "orange":
                            price = number * 0.85;
                            break;
                        case "grapefruit":
                            price = number * 1.45;
                            break;
                        case "kiwi":
                            price = number * 2.70;
                            break;
                        case "pineapple":
                            price = number * 5.50;
                            break;
                        case "grapes":
                            price = number * 3.85;
                            break;
                        default:
                            Console.WriteLine("error");
                            break;
                    }
                    break;
                case "Saturday":
                case "Sunday":
                    switch (fruit)
                    {
                        case "banana":
                            price = number * 2.7;
                            break;
                        case "apple":
                            price = number * 1.25;
                            break;
                        case "orange":
                            price = number * 0.9;
                            break;
                        case "grapefruit":
                            price = number * 1.6;
                            break;
                        case "kiwi":
                            price = number * 3;
                            break;
                        case "pineapple":
                            price = number * 5.60;
                            break;
                        case "grapes":
                            price = number * 4.2;
                            break;
                        default:
                            Console.WriteLine("error");
                            break;
                    }
                    break;
                 default:
                    Console.WriteLine("error");
                    break;
            }

            if (price > 0)
            {
                Console.WriteLine($"{price:f2}");
            }



        }
    }
}
