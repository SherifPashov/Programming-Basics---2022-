using System;

namespace _03._Deposit_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double deposit = double.Parse(Console.ReadLine());

            
            double month = double.Parse(Console.ReadLine());
           
            double parsent = double.Parse(Console.ReadLine());


            double finalParsent = parsent / 100;
            double lihva = deposit * finalParsent/12; 

            double money = deposit + month * lihva;
            Console.WriteLine(money);
        }
    }
}
