using System;

namespace _01._PC_Store
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double cpu = double.Parse(Console.ReadLine());
            double gpu = double.Parse(Console.ReadLine());
            double ram = double.Parse(Console.ReadLine());
            int numberRAM = int.Parse(Console.ReadLine());
            double parcentDiscount = double.Parse(Console.ReadLine());

            double bgcpu = cpu * 1.57 ;
            double bggpu = gpu * 1.57 ;
            double finishCPU = bgcpu * parcentDiscount;
            double finishGPU = bggpu * parcentDiscount;
            bgcpu-=finishCPU;
            bggpu-=finishGPU;
            double bgRAM = ram * 1.57 * numberRAM;

            double priceAll = bgcpu + bggpu + bgRAM;
            Console.WriteLine($"Money needed - {priceAll:f2} leva.");
        }
    }
}
