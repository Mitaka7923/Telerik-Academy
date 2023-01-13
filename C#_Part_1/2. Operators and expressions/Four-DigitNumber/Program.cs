// Problem 6
// Write a program that takes as input a four-digit number in format abcd (e.g. 2011) and performs the following:
// Calculates the sum of the digits (in our example 2 + 0 + 1 + 1 = 4).
// Prints on the console the number in reversed order: dcba (in our example 1102).
// Puts the last digit in the first position: dabc (in our example 1201).
// Exchanges the second and the third digits: acbd (in our example 2101).

using System;

namespace Four_DigitNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int input = int.Parse(Console.ReadLine());
            int num1 = (input / 1000) % 10;
            int num2 = (input / 100) % 10;
            int num3 = (input / 10) % 10;
            int num4 = input % 10;

            if (input.ToString().Length != 4)
            {
                Console.Clear();
                Console.WriteLine("ENTER A FOUR DIGIT POSITIVE NUMBER!!!");
                return;
            }
            else
            {
                Console.Clear();
                Console.WriteLine($"Number: {input}\n");
                Console.WriteLine($"Sum of digits is: {num1 + num2 + num3 + num4}");
                Console.WriteLine($"Digits in reverse order: {num4}{num3}{num2}{num1}");
                Console.WriteLine($"Last digit in first position: {num4}{num1}{num2}{num3}");
                Console.WriteLine($"Exchange second and third digits: {num1}{num3}{num2}{num4}");
            }
        }
    }
}