using System;

namespace _06._Cake
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int a = int.Parse(Console.ReadLine());
           int b = int.Parse(Console.ReadLine());
            int s = a * b;
            string cake = Console.ReadLine();
           
            while (cake != "STOP")
            {
                int cakePart = int.Parse(cake);
                s -= cakePart;
                if (s <= 0)
                {
                    int dis = Math.Abs(s); 
                    Console.WriteLine($"No more cake left! You need {dis} pieces more.");
                    break;
                }

                cake = Console.ReadLine();
            }
            if (cake == "STOP")
            {

                Console.WriteLine($"{s} pieces are left.");
            }
        }
    }
}
