using System;

// Problem 1
// Write a program that enters from the console a positive integer n 
// and prints all the numbers from 1 to n, on a single line, separated by a space.

namespace _01.NumbersFrom1ToN
{
    class Program
    {
        private static int inputNum = 0;

        public static void Main()
        {
            do
            {
                Console.Clear();
                Console.WriteLine("Please enter a positive integer for n. ");
                Console.Write("n = ");
                inputNum = int.Parse(Console.ReadLine());
            } while (inputNum <= 0);
            ConsoleOuput();
        }

        private static void ConsoleOuput()
        {
            for (int startingValue = 1; startingValue <= inputNum; startingValue++)
            {
                Thread.Sleep(250);
                Console.Write($"{startingValue} ");
            }
        }
    }
}