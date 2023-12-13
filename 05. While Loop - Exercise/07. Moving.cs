using System;

namespace _07._Moving
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int h = int.Parse(Console.ReadLine());

            int v = a * b * h;
            string box = Console.ReadLine();
            while (box != "Done")
            {
                int boxV = int.Parse(box);
                v-= boxV;
                if (v <= 0  )
                {
                    int def = Math.Abs(v);
                    Console.WriteLine($"No more free space! You need {def} Cubic meters more.");
                    break;
                }
                box = Console.ReadLine();

            }
            if (box == "Done")
            {
                Console.WriteLine($"{v} Cubic meters left.");
            }
        }
    }
}
