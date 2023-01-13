// Write a program that gets two numbers from the console and prints the greater of them. 
// Try to implement this without if statements.

using System;

namespace Number_Comparer
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1 = double.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());

            Console.WriteLine($"\nThe greater number is: {Math.Max(num1, num2)}");
        }
    }
}
