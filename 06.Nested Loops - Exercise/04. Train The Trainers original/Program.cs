using System;

namespace _04._Train_The_Trainers_original
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int jury = int.Parse(Console.ReadLine());
            string tema = Console.ReadLine();
            double numberTema = 0;
            double sumOcenki = 0;
            while (tema != "Finish")
            {
                double averageTema = 0;
                for (int i = 0; i < jury; i++)
                {
                    double ocenka = double.Parse(Console.ReadLine());
                    averageTema += ocenka;
                    sumOcenki += ocenka;
                    numberTema++;
                }
                averageTema /= jury;
                Console.WriteLine($"{tema} - {averageTema:f2}.");
                tema = Console.ReadLine();
            }
            
           
            Console.WriteLine($"Student's final assessment is {sumOcenki / numberTema:f2}.");

        }
    }
}
