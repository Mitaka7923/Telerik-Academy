//Problem 3. Compare char arrays
//Write a program that compares two char arrays lexicographically (letter by letter).

using System;

namespace _03._CompareCharArrays
{
    internal class Program
    {
        private static void Main()
        {
            Console.Write("Enter first array : ");
            var firstArray = Console.ReadLine()!;
            Console.Write("Enter second array: ");
            var secondArray = Console.ReadLine()!;

            var areEqual = true;
            if (firstArray.Length != secondArray.Length)
            {
                areEqual = false;
            }
            else
            {
                for (int i = 0; i < firstArray.Length; i++)
                {
                    if (firstArray[i] != secondArray[i])
                    {
                        areEqual = false;
                    }
                }
            }

            Console.WriteLine($"\tAre equal: {areEqual}");
        }
    }
}