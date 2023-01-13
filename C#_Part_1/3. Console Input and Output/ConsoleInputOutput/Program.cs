// Write a program that reads 3 real numbers from the console and prints their sum.

using System;

namespace ConsoleInputOutput
{
    class Program
    {
        //Here I use the method TryParse so the user can enter characters and bypassing exeption - "Input string was not in a correct format."
        static void Main(string[] args)
        {
            Console.Write("Enter the first number: ");
            string num1 = Console.ReadLine();
            Console.Write("Enter the second number: ");
            string num2 = Console.ReadLine();
            Console.Write("Enter the third number: ");
            string num3 = Console.ReadLine();
            string warning = "Please enter valid numbers and try again...";

            if (!int.TryParse(num1, out int parsedNum1) || !int.TryParse(num2, out int parsedNum2) || !int.TryParse(num3, out int parsedNum3))
            {
            Console.Clear();
            Console.WriteLine(warning);
            }
            else
            {
            Console.Clear();
            int sum = parsedNum1 + parsedNum2 + parsedNum3;
            Console.WriteLine($"The sum is: {sum}");
            }
        }
    }
}
