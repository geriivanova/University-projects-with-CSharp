﻿namespace _04._Correct_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            while(!(number >= 5 && number <= 50))
            {
                Console.WriteLine("Въведете коректно число: ");
                number = double.Parse(Console.ReadLine());
            }
            Console.WriteLine(Math.Pow(number, 2));
        }
    }
}