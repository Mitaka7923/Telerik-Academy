//Problem 4. Maximal sequence
//Write a program that finds the maximal sequence of equal elements in an array.
//Example:
//input 	                                result
//2, 1, 1, 2, 3, 3, 2, 2, 2, 1          	2, 2, 2

using System;

namespace _04._MaximalSequence
{
    internal class Program
    {
        private static void Main()
        {
            Console.Write("Enter array: ");
            var inputArray = Console.ReadLine()!.Split(new string[] { ", ", " ", ",", " ," }, StringSplitOptions.RemoveEmptyEntries);
            var array = new int[inputArray!.Length];
            var maxSequence = 1;
            var max = 1;
            var number = 0;

            for (int i = 0; i < inputArray.Length; i++)
            {
                if (int.TryParse(inputArray[i], out int currentNumber))
                {
                    array[i] = currentNumber;
                }
                else
                {
                    Console.WriteLine("ERROR");
                    Environment.Exit(0);
                }
            }

            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] == array[i + 1])
                {
                    if (i != 0 && array[i] != array[i - 1])
                    {
                        maxSequence = 2;
                    }
                    else
                    {
                        maxSequence++;
                    }
                }

                if (maxSequence > max)
                {
                    number = array[i];
                    max = maxSequence;
                }
            }

            var list = new List<int>();
            for (int i = 0; i < max; i++)
            {
                list.Add(number);
            }

            Console.Clear();
            Console.WriteLine($"Number array: {string.Join(", ", array)}\n");
            Console.WriteLine($"Maximum numbers in sequence: {String.Join(", ", list)}");
        }
    }
}