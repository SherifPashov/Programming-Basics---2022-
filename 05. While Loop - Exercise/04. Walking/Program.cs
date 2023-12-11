using System;

namespace _04._Walking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string steps = Console.ReadLine();
            int sumSteps = 0;
            while (steps != "Going home")
            {
                int sumSteps1 = int.Parse(steps);
                sumSteps += sumSteps1;
                if (sumSteps >= 10000)
                {
                    int dis = Math.Abs(10000 - sumSteps);
                    Console.WriteLine($"Goal reached! Good job!");
                    Console.WriteLine($"{dis} steps over the goal!");
                    break;
                }
                steps = Console.ReadLine();
            }
            if (steps == "Going home")
            {
                steps = Console.ReadLine();
                int sumSteps1 = int.Parse(steps);
                sumSteps += sumSteps1;

                if (sumSteps < 10000)
                {
                    int dis = Math.Abs(10000 - sumSteps);
                    Console.WriteLine($"{dis} more steps to reach goal.");
                }
                else if (sumSteps >= 10000)
                {
                    int dis = Math.Abs(10000 - sumSteps);
                    Console.WriteLine($"Goal reached! Good job!");
                    Console.WriteLine($"{dis} steps over the goal!");
                }
            }

        }
    }
}
