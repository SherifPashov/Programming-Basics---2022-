using System;

namespace _03._Sum_Prime_Non_Prime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int sumPrime = 0;
            int sumNoPrime = 0;
            
            while (text != "stop")
            {
                int number = int.Parse(text);
                int deleno = 0;
                if (number < 0 )
                {
                        Console.WriteLine("Number is negative.");
                        text = Console.ReadLine();
                        continue;
                }
                else if (number == 0 )
                {
                    text = Console.ReadLine();
                    continue;
                }
                
                for (int i = 1; i <= number; i++)
                {
                    if (number % i == 0)
                    {
                        deleno++;
                    }
                    
                }
                if (deleno == 2)
                {
                    sumPrime += number;
                }
                else if (deleno > 2)
                {
                    sumNoPrime += number;
                }

                text = Console.ReadLine();
            }
            Console.WriteLine($"Sum of all prime numbers is: {sumPrime}");
            Console.WriteLine($"Sum of all non prime numbers is: {sumNoPrime}");
        }
    }
}
