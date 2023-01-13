﻿// Write a program that reads an integer number n from the console and prints 
// all the numbers in the interval [1..n], each on a single line. Note that you 
// may need to use a for-loop.

using System;

namespace Numbers_From_0_To_N
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i < n + 1; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
