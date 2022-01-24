// Write a program that reads a number n and prints on the console the first n members of the Fibonacci 
// sequence (at a single line, separated by spaces) : 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, …. 
// Note that you may need to learn how to use loops. */

//Fibonacci Sequence is first number + second number = third number

using System;
using System.Numerics;

namespace Fibonacci_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            // Here I do some exeption handling
            int lenght;
            try
            {
                lenght = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("INVALID NUMBER!");
                Console.ForegroundColor = ConsoleColor.Gray;
                return;
            }

            BigInteger firstNumber = 0;
            BigInteger secondNumber = 1;

            Console.WriteLine($"The first {lenght} numbers of the Fibonacci Sequence are:");

            if (lenght <= 1)
            {
                Console.WriteLine($"{firstNumber}");
            }
            else
            {
                BigInteger nextNumber = firstNumber + secondNumber;
                Console.Write($"{firstNumber} {secondNumber} ");
                for (int i = 2; i < lenght; i++)
                {
                    Console.Write($"{nextNumber} ");
                    BigInteger intermediate = nextNumber;
                    nextNumber += secondNumber;
                    secondNumber = intermediate;
                }
            }
        }
    }
}
