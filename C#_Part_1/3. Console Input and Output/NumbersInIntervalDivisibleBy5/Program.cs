// Write a program that reads two positive integer numbers and prints how many numbers p exist 
// between them such that the reminder of the division by 5 is 0.

using System;

namespace NumbersInIntervalDivisibleBy5
{
    class Program
    {
        static void Main(string[] args)
        {
            uint num1 = default;
            uint num2 = default;
            uint p = default;

            try
            {
                Console.Write("Enter the first positive number: ");
                num1 = uint.Parse(Console.ReadLine());
                Console.Write("Enter the second positive number: ");
                num2 = uint.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Clear();
                Console.WriteLine("INVALID NUMBER!");
                Console.ForegroundColor = ConsoleColor.Gray;
                return;
            }

            for (uint i = num1; i < num2; i++)
            {
                if (i % 5 == 0)
                {
                    p++;
                }
            }

            if (p == 1)
                Console.WriteLine($"\nYou can divide {p} time in the bounries of {num1} - {num2}");
            else
                Console.WriteLine($"\nYou can divide {p} times in the bounries of {num1} - {num2}");
        }
    }
}
