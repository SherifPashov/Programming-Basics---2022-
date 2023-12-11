using System;

namespace _04._Personal_Titles
{
    internal class Program
    {
        static void Main(string[] args)
        {
           double age = double.Parse(Console.ReadLine());
            string sex = Console.ReadLine();
            if (sex == "m")

            {
                if (age < 16)
                {
                    Console.WriteLine("Master");
                }
                else if (age >= 16)
                {
                    Console.WriteLine("Mr.");
                }

            }
            else if (sex == "f")
            {
                {
                    if (age < 16)
                    {
                        Console.WriteLine("Miss");
                    }
                    else if (age >= 16)
                    {
                        Console.WriteLine("Ms.");
                    }

                }
            }


        }
    }
}
