using System;

namespace _04._Renova
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double h = double.Parse(Console.ReadLine());
            double a = double.Parse(Console.ReadLine());
            int parcent = int.Parse(Console.ReadLine());
            double s1 = h * a * 4;
            double s2 = s1 * parcent / 100;
            double paint =Math.Ceiling( s1 -s2);
            string litersPaint = Console.ReadLine();
            while (litersPaint != "Tired!")
            {
                int numberPaint = int.Parse(litersPaint);
                paint -= numberPaint;
                if (paint == 0)
                {
                    Console.WriteLine("All walls are painted! Great job, Pesho!");
                    break;
                }
                else if (paint < 0)
                {
                    Console.WriteLine($"All walls are painted and you have {Math.Abs(paint)} l paint left!" );
                    break;
                }


                litersPaint = Console.ReadLine();
            }
            if (litersPaint == "Tired!")
            {
                Console.WriteLine($"{paint} quadratic m left.");
            }
            
        }
    }
}
