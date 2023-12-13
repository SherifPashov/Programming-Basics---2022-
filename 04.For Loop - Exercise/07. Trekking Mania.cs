using System;

namespace _07._Trekking_Mania
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberGrupe = int.Parse(Console.ReadLine());
            int grupe1 = 0;
            int grupe2 = 0;
            int grupe3 = 0;
            int grupe4 = 0;
            int grupe5 = 0;
            int people = 0;

            for (int i = 0; i < numberGrupe; i++)
            {
                int nemberPeople = int.Parse(Console.ReadLine());
                if (nemberPeople <= 5)
                {
                    grupe1 += nemberPeople;
                    people += nemberPeople;
                }
                else if (nemberPeople > 5 && nemberPeople <= 12)
                {
                    grupe2 += nemberPeople;
                    people += nemberPeople;

                }
                else if (nemberPeople > 12 && nemberPeople <= 25)
                {
                    grupe3 += nemberPeople;
                    people += nemberPeople;
                }
                else if (nemberPeople >25 && nemberPeople <= 40 )
                {
                    grupe4 += nemberPeople;
                    people += nemberPeople;
                }
                else if (nemberPeople > 40)
                {
                    grupe5 += nemberPeople;
                    people += nemberPeople;
                }
                

            }
            double percentGrupe1 = grupe1 * 1.00 / people * 100;
            double percentGrupe2 = grupe2 * 1.00 / people * 100;
            double percentGrupe3 = grupe3 * 1.00 / people * 100;
            double percentGrupe4 = grupe4 * 1.00 / people * 100;
            double percentGrupe5 = grupe5 * 1.00 / people * 100;

            Console.WriteLine($"{percentGrupe1:f2}%");
            Console.WriteLine($"{percentGrupe2:f2}%");
            Console.WriteLine($"{percentGrupe3:f2}%");
            Console.WriteLine($"{percentGrupe4:f2}%");
            Console.WriteLine($"{percentGrupe5:f2}%");
        }
    }
}
