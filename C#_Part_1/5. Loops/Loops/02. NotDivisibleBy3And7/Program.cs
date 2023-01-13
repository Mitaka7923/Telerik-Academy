using System;

// Problem 2
// Write a program that enters from the console a positive integer n 
// and prints all the numbers from 1 to n not divisible by 3 and 7, 
// on a single line, separated by a space.

namespace _02.NotDivisibleBy3And7
{
    class Program
    {
        static void Main()
        {
            string input;
            int inputNum;

            do
            {
                Console.Clear();
                Console.Write("Enter a valid number: ");
                input = Console.ReadLine();
            } while (!int.TryParse(input, out inputNum));

            for (int value = 1; value <= inputNum; value++)
            {
                if (value % 3 != 0 && value % 7 != 0) 
                {
                    Thread.Sleep(100);
                    Console.Write($"{value} ");
                }
            }

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine($"{Environment.NewLine}Process completed.");
            Console.ForegroundColor = ConsoleColor.Gray;
        }       
    }
}