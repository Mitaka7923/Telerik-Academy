// Write a program that enters 5 numbers (given in a single line, separated by a space), calculates and prints their sum. 

using System;

namespace Sum_Of_5_Numbers
{
    class Program
    {
        //                      LATER
        static void Main(string[] args)
        {
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine(i);
            }
            string num = Console.ReadLine();
            Convert.ToInt32(num);
        }
    }
}
