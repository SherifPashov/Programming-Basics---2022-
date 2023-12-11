using System;

namespace _04._Workout
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberDay = int.Parse(Console.ReadLine());
            double kmForOneDay = double.Parse(Console.ReadLine());
            double allkm = kmForOneDay;

            for (int i = 0; i < numberDay; i++)
            {
               double parcent = double.Parse(Console.ReadLine());
                double translateParcent = (parcent / 100) + 1;
                kmForOneDay = kmForOneDay * translateParcent;
                allkm += kmForOneDay;
            }
           
            if (allkm >= 1000)
            {
                double def = Math.Ceiling(allkm - 1000);
                Console.WriteLine($"You've done a great job running {def} more kilometers!");
            }
            else if (allkm < 1000)
            {
                double def =Math.Ceiling(1000 - allkm);
                Console.WriteLine($"Sorry Mrs. Ivanova, you need to run {def} more kilometers");
            }
        }
    }
}
