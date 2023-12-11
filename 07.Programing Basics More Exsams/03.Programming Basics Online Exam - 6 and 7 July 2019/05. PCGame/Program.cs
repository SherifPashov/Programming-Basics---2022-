using System;

namespace _05._PCGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int saleGame = int.Parse(Console.ReadLine());

            int hearthstone = 0;
            int fornite = 0;
            int overwatch = 0;
            int others = 0;
            
            for (int i = 0; i < saleGame; i++)
            {
                string nameGame = Console.ReadLine();
                switch (nameGame)
                {
                    case "Hearthstone":
                        hearthstone++;
                        break;
                    case "Fornite":
                        fornite++;
                        break;
                    case "Overwatch":
                        overwatch++;
                        break;
                    default:
                        others++;
                        break;
                }
            }
            double parcentHearth = hearthstone * 100.0 / saleGame;
            double parcentFornite = fornite * 100.0 / saleGame;
            double parcentOverwatch = overwatch * 100.0 / saleGame;
            double parcentOthers = others * 100.00 / saleGame;

            Console.WriteLine($"Hearthstone - {parcentHearth:f2}%");
            Console.WriteLine($"Fornite - {parcentFornite:f2}%");
            Console.WriteLine($"Overwatch - {parcentOverwatch:f2}%");
            Console.WriteLine($"Others - {parcentOthers:f2}%");

        }
    }
}
