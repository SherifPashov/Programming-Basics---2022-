using System;

namespace _05._Everest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string yesOrNo = Console.ReadLine();
            int day = 1;
            int m = 5364;
            while (yesOrNo != "END")
            {

                
                
                if (yesOrNo == "Yes")
                {
                    day++;
                }
                
                if (day > 5)
                {
                    break;
                }

                int meters = int.Parse(Console.ReadLine());
                m += meters;
                if (m >=8848 )
                {
                    break;
                }
               

                yesOrNo = Console.ReadLine();
            }
            if (m < 8848)
            {
                Console.WriteLine("Failed!");
                Console.WriteLine($"{m}");
            }
            else if (m >= 8848)
            {
                Console.WriteLine($"Goal reached for {day} days!");
            }
        }
    }
}
