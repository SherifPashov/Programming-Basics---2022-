using System;

namespace _04._Train_The_Trainers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            
            for (int first = 1; first <= 9; first++)
            {
                for (int second = 1; second <= 9; second++)
                {
                    for (int thirt = 1; thirt <= 9; thirt++)
                    {
                        for (int four = 1; four <= 9; four++)
                        {
                            int magic = 0;
                            if (n % first ==0)
                            {
                                magic++;
                            }
                            if (n % second == 0)
                            {
                                magic++;
                            }
                            if (n % thirt == 0)
                            {
                                magic++;
                            }
                            if (n % four == 0)
                            {
                                magic++;
                            }

                            if (magic == 4)
                            {
                                Console.Write($"{first}{second}{thirt}{four} ");
                            }
                        }
                    }
                }
            }
        }
    }
}
