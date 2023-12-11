using System;

namespace _08._On_Time_for_the_Exam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hoursTest = int.Parse(Console.ReadLine());
            int minutesTest = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            int hoursTestForMinutes = hoursTest * 60;
            int hoursForMinutes = hours * 60;

            int allMinutesTest = hoursTestForMinutes + minutesTest;
            int allMinutes = hoursForMinutes + minutes;

            if (allMinutesTest < allMinutes)
            {
                Console.WriteLine("Late");
                if (allMinutes - allMinutesTest < 60 )
                {
                    Console.WriteLine($"{allMinutes - allMinutesTest} minutes after the start");
                }
                else 
                {
                    int hoursFinsih = (allMinutes - allMinutesTest) / 60;
                    int minutesFinish = (allMinutes - allMinutesTest) % 60;
                    Console.WriteLine($"{hoursFinsih}:{minutesFinish:d2} hours after the start");
                }

            }
            else if (allMinutesTest == allMinutes || allMinutesTest - allMinutes <= 30)
            {
                Console.WriteLine("On time");
                if (allMinutes - allMinutesTest !=0)
                {
                    Console.WriteLine($"{allMinutesTest - allMinutes} minutes before the start");
                }

            }
            else if (allMinutesTest - allMinutes > 30)
            {
                Console.WriteLine("Early");
                if (Math.Abs(allMinutes - allMinutesTest) < 60 )
                {
                    Console.WriteLine($"{allMinutesTest - allMinutes} minutes before the start");
                }
                else
                {
                    int hoursFinish = (allMinutesTest - allMinutes) / 60;
                    int minutesFinish = (allMinutesTest - allMinutes) % 60;
                    Console.WriteLine($"{hoursFinish}:{minutesFinish:d2} hours before the start");
                }
            }
            



        }
    }
}
