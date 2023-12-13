using System;

namespace _06._Cinema_Tickets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nameFilm = Console.ReadLine();
            
            double studentSum = 0;
            double standartSum = 0;
            double kidSum = 0;
            double totalTicket=0;


            while (nameFilm != "Finish")
            {   
                int busy = 0;
                double freely = double.Parse(Console.ReadLine());
                  string people = Console.ReadLine();
                while (people != "End")
                {
                    
                    switch (people)
                    {
                        case "student":
                            studentSum++;
                            totalTicket++;
                            busy++;
                            break;
                        case "standard":
                            standartSum++;
                            totalTicket++;
                            busy++;
                            break;
                        case "kid":
                            kidSum++;
                            totalTicket++;
                            busy++;
                            break;
                        
                    }
                    if (freely <= busy)
                    {
                        break;
                    }
                    people = Console.ReadLine();
                    
                }
                 double purcent = busy /freely * 100.0;
                Console.WriteLine($"{nameFilm} - {purcent:f2}% full.");

                nameFilm = Console.ReadLine();
            }
            double purcentStudent = studentSum / totalTicket * 100;
            double purcentStandart = standartSum / totalTicket * 100;
            double purcentKid = kidSum / totalTicket * 100;
            Console.WriteLine($"Total tickets: {totalTicket}");
            Console.WriteLine($"{purcentStudent:f2}% student tickets.");
            Console.WriteLine($"{purcentStandart:f2}% standard tickets.");
            Console.WriteLine($"{purcentKid:f2}% kids tickets.");
        }
    }
}
