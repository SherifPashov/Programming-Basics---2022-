﻿using System;

namespace _06._Concatenate_Data
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String firstName = Console.ReadLine();
            String lastName = Console.ReadLine();
            int age =int.Parse(Console.ReadLine());
            string town = Console.ReadLine();
            Console.WriteLine($"You are {firstName} {lastName}, a {age}-years old person from {town}.");
        }
    }
}
