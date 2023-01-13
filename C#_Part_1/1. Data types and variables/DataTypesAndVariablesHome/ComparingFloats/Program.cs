//Write a program that safely compares floating-point numbers (double) with precision eps = 0.000001.
//Note: Two floating-point numbers a and b cannot be compared directly by a == b because of the nature of the 
//floating-point arithmetic. Therefore, we assume two numbers are equal if they are more closely to each other 
//than a fixed constant eps.

using System;

namespace DeclareVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter A value: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Enter B value: ");
            double b = double.Parse(Console.ReadLine());

            a = Math.Round(a, 6);
            b = Math.Round(b, 6);
            Console.WriteLine("Is A equal to B?");

            if (a == b)
            {
                Console.WriteLine($"A = {a} and B = {b} are equal.");
            }

            if (a > b)
            {
                Console.WriteLine($"NO! They are not equal and at the moment A = {a} is greater than B = {b}! Please try again...");
            }

            if (a < b)
            {
                Console.WriteLine($"NO! They are not equal and at the moment B = {b} is greater than A = {a}! Please try again...");
            }
        }
    }
}
