using System;

namespace _01._Pipes_In_Pool
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int v = int.Parse(Console.ReadLine());
            int p1 = int.Parse(Console.ReadLine());
            int p2 = int.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());

            double debitP1 = h * p1;
            double debitP2 = h * p2;
            double sum = debitP1 + debitP2;


            if (sum <= v)
            {
                double parcentP1 = debitP1 / sum * 100;
                double parcentP2 = debitP2 / sum *100;
                double parcentV = sum / v * 100;
                Console.WriteLine($"The pool is {parcentV:f2}% full. Pipe 1: {parcentP1:f2}%. Pipe 2: {parcentP2:f2}%.");
            }
            else if (sum > v)
            {
                double def = sum - v;
                Console.WriteLine($"For {h:f2} hours the pool overflows with {def:f2} liters.");
            }


        }
    }
}
