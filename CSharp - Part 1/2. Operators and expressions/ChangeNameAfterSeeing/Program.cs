// Problem 1
// Write an expression that checks if given integer is odd or even. 

using System;

namespace ChangeNameAfterSeeing
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a number: ");
            int num = int.Parse(Console.ReadLine());

            Console.Clear();
            Console.WriteLine((num % 2 != 0) ? "This number is Odd." : "This number is Even.");
        }
    }
}