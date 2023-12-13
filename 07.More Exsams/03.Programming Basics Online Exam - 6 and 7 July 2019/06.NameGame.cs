using System;

namespace _06.NameGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int asii = 0;
            int pointsWinPlayar = 0;
            string nameWiner = "";
            while (name != "Stop")
            {
                int pointsOnePlayar = 0;
                
                
                   
                    foreach (char c in name)
                    { 
                        int points = int.Parse(Console.ReadLine());
                         asii = ((int)c);
                        
                        if (points == asii)
                        {
                             pointsOnePlayar += 10;
                        }
                        else 
                        {
                        pointsOnePlayar += 2;
                        }
                    }
                    
                   
                
                if (pointsWinPlayar <= pointsOnePlayar)
                {
                    nameWiner = name;
                    pointsWinPlayar = pointsOnePlayar;
                }
                name = Console.ReadLine();
            }
            Console.WriteLine($"The winner is {nameWiner} with {pointsWinPlayar} points!");
            
        }
    }
}
