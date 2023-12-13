using System;

namespace _05._Salary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tab = int.Parse(Console.ReadLine());
            int selary = int.Parse(Console.ReadLine());

            for (int i = 0; i < tab; i++)
            {
                string tabName = Console.ReadLine();
                switch (tabName)
                {
                    case "Facebook":
                        selary -= 150;
                        break;
                    case "Instagram":
                        selary -= 100;
                        break;
                    case "Reddit":
                        selary -= 50;
                        break;
                    
                }
                if (selary <=0)
                {
                    Console.WriteLine("You have lost your salary.");
                    break;
                }

            }
            if (selary > 0)
            {
                Console.WriteLine(selary);
            }
           
                



        }
    }
}
