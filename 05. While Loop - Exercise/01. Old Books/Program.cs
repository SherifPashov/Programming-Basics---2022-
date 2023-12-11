using System;

namespace _01._Old_Books
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string bookFevorite = Console.ReadLine();
            string book = ""; 
            int numberBook = 0;
            while (book != "No More Books")
            {
                book = Console.ReadLine();
                

                if (book == bookFevorite)
                {
                    Console.WriteLine($"You checked {numberBook} books and found it.");
                    break;
                }
                numberBook++;
            }
            if (book == "No More Books")
            {
                Console.WriteLine("The book you search is not here!");
                Console.WriteLine($"You checked {numberBook - 1} books.");
            }
        }
    }
}
