// Problem 3 -
// Write a Boolean expression that checks by given integer if it can be divided 
// (without remainder) by 7 and 5 in the same time.

using System;

namespace DivideBy7And5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a integer to check if it can be divided by 7 and 5 at the same time: ");
            int input = int.Parse(Console.ReadLine());
            bool division = (input % 7 == 0) && (input % 5 == 0);

            Console.Clear();
            Console.WriteLine(division ? "The number IS divisable by 7 and 5." : "The number IS NOT divisable by 7 and 5.");
        }
    }
}
