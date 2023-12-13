using System;

namespace _07.Working_Hours
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());  
            string day = Console.ReadLine();
            switch (hours)
            {
                case 10:
                case 11:
                case 12:
                case 13:
                case 14:
                case 15:
                case 16:
                case 17:
                case 18:

                    switch (day)
                    {
                        case "Monday":
                        case "Tuesday":
                        case "Wednesday":
                        case "Thursday":
                        case "Friday":
                        case "Saturday":
                            Console.WriteLine("open");
                            break;
                        case "Sunday":
                            Console.WriteLine("closed");
                            break;
                    
                    }
                    break;
                default:
                    Console.WriteLine("closed");
                    break ;
                    
            }




        }
    }
}
