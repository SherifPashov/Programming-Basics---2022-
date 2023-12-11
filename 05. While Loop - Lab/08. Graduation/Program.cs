using System;

namespace _08._Graduation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            
            double number = double.Parse(Console.ReadLine());
            double sum = 0;
            int grade = 0;
            
            int fell = 0;
            while (true)
            {
                grade++;
                if (number < 4.00)
                {
                    grade--;
                    fell++;
                }
                if (fell == 2 )
                {
                    Console.WriteLine($"{name} has been excluded at {grade+1} grade");
                    break;
                }
                sum += number;
                if (grade == 12 )
                {
                    break;
                }
                number = double.Parse(Console.ReadLine());
                
            }
            if (grade == 12 )
            {
                double average = sum / 12;
                Console.WriteLine($"{name} graduated. Average grade: {average:f2}");
            }
        }
    }
}
