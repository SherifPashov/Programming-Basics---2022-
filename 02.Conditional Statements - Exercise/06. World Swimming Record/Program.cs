using System;

namespace _06._World_Swimming_Record
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double record  = double.Parse(Console.ReadLine());
            double distance = double.Parse(Console.ReadLine());
            double timieForOneM = double.Parse(Console.ReadLine());

            double timeForAllM = distance * timieForOneM;
            double resistance = Math.Floor (distance / 15) ;
            double timeAll = timeForAllM + (resistance * 12.5);

            if (timeAll < record)
            {
                Console.WriteLine($" Yes, he succeeded! The new world record is {timeAll:f2} seconds.");
            }
            else if (timeAll >= record)
            {
                Console.WriteLine($"No, he failed! He was {timeAll - record:f2} seconds slower.");
            }






        }
    }
}
