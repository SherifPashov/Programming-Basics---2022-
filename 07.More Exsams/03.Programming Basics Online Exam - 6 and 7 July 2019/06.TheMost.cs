using System;

namespace _06.TheMost
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            for (int n1 = start / 1000; n1 <= end / 1000; n1++)
            {
                 if (n1 % 2 == 0)
                 {
                    continue;
                 }

                for (int n2 = start / 100 % 10 ; n2 <= end / 100 % 10; n2++)
                {
                    if (n2 % 2 == 0)
                    {
                      continue;
                    }
                    for (int n3 = start % 100 / 10; n3 <= end % 100 / 10; n3++)
                    { 
                        if (n3 % 2 == 0)
                        {
                             continue;
                        }
                        for (int n4 = start % 10; n4 <= end % 10; n4++)
                        {
                            if (n4 % 2 == 0)
                            {
                                continue;
                            }
                            Console.Write($"{n1}{n2}{n3}{n4} ");
                        }
                         
                    }
                }
 
            }
        }
    }
}
