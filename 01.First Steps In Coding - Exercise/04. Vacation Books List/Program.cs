using System;

namespace _04._Vacation_Books_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int namberPage = int.Parse(Console.ReadLine());
            int page =int.Parse(Console.ReadLine());
           int days = int.Parse(Console.ReadLine());

           int hourForDays = namberPage / page;
            int hour = hourForDays / days;
            Console.WriteLine(hour);
             

        }
    }
}
