using System;

namespace _02._Equal_Sums_Even_Odd_Position
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNimber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            
            for (int i = firstNimber; i <= secondNumber; i++)
            {
                string number = i.ToString();
                int evenSum = 0;
                int oddSum = 0;
                for (int e = 0; e < number.Length; e++)
                {
                    int numberTransoformation = int.Parse(number[e].ToString());
                    if (e % 2 == 0)
                    {
                        evenSum += numberTransoformation;

                    }
                    else
                    {
                        oddSum+= numberTransoformation;
                    }
                }
                if (oddSum == evenSum)
                {
                    Console.Write($"{i} ");
                }
            }
        }
    }
}
