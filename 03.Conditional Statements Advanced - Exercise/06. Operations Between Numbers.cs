using System;

namespace _06._Operations_Between_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double n1 = double.Parse(Console.ReadLine());
            double n2 = double.Parse(Console.ReadLine());
            char operation = char.Parse(Console.ReadLine());
            double sum = 0;
            switch (operation)
            {
                case '+':
                sum = n1 + n2;
                    Console.Write($"{n1} {operation} {n2} = {sum}");
                    break;
                case '-':
                    sum = n1 - n2;
                    Console.Write($"{n1} {operation} {n2} = {sum}");
                    break;
                case '*':
                    sum = n1 * n2;
                    Console.Write($"{n1} {operation} {n2} = {sum}");
                    break;
                case '/':
                    if (n2 ==0)
                    {
                        Console.WriteLine($"Cannot divide {n1} by zero");
                    }
                    else
                    {
                        sum = n1 / n2;
                        Console.Write($"{n1} {operation} {n2} = {sum:f2}");
                    }
                    break;
                case '%':
                    if (n2 == 0)
                    {
                        Console.WriteLine($"Cannot divide {n1} by zero");
                    }
                    else
                    {
                        sum = n1 % n2;
                        Console.Write($"{n1} {operation} {n2} = {sum}");
                    }
                    
                    break;

            }
            
            switch (operation)
            {
                case '+':
                case '-':
                case '*':
                    if (sum %2 == 0 )
                    {
                        Console.Write(" - even");
                    }
                    else
                    {
                        Console.Write(" - odd");
                    }
                    break;
            }
            

        }
    }
}
