using System;

namespace _02._Exam_Preparation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int fell = int.Parse(Console.ReadLine());
            int numberFell = 0;
            int numberExs = 0;
            double sum = 0;
            string lastExs = "";
            string nameExs = Console.ReadLine();
            while ( fell != numberFell)
            {
                if (nameExs == "Enough")
                {
                    double average = sum / numberExs;
                    Console.WriteLine($"Average score: {average:f2}");
                    Console.WriteLine($"Number of problems: {numberExs}");
                    Console.WriteLine($"Last problem: {lastExs}");
                    break;
                }
                double ocenka = double.Parse(Console.ReadLine());
                numberExs++;
                sum += ocenka;
                if (ocenka <= 4)
                {
                    numberFell++;
                }
                if (nameExs != "Enough")
                {
                    lastExs = nameExs;
                }
                if (fell == numberFell)
                {
                    break;
                }
                
                
                
                nameExs = Console.ReadLine();
            }
            if (fell == numberFell)
            {
                Console.WriteLine($"You need a break, {numberFell} poor grades.");
            }
        }
    }
}
