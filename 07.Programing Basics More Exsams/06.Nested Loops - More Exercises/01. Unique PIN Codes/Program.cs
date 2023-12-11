using System;

namespace _01._Unique_PIN_Codes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x1 = int.Parse(Console.ReadLine());
            int x2 = int.Parse(Console.ReadLine());
            int x3 = int.Parse(Console.ReadLine());
            int dis = 0;
            int f1= 0;
            int f2 = 0;
            int f3 = 0;
            
            
                for (int first = 1; first <= x1; first++)
                {       
                    f1 = first;
                    if (first % 2 == 1 )
                    {
                        continue;
                    }
                       
                    
                    for (int second = 1; second <= x2; second++)
                    {   
                        dis = 0;
                        f2 = second;
                            for (int q = 1; q <= 9; q++)
                            {
                               
                              if (second % q == 0)
                              {
                                dis++;
                              }
                            }
                            if (dis != 2 )
                            {
                              continue;
                            }
                        for (int tree = 1; tree <= x3; tree++)
                        { 
                            f3 = tree;
                            if (tree % 2 == 1)
                            {
                                continue;
                            }
                            
                            Console.WriteLine($"{f1} {f2} {f3}");
                        }
                        
                    }
                }

        }
    }
}
