//Problem 13. Check a Bit at Given Position
//Write a Boolean expression that returns if the bit at position p (counting from 0, starting from the right)
//in given integer number n, has value of 1.


using System;

namespace BitAtPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int pos = int.Parse(Console.ReadLine());

            int mask = 1 << pos;
            int numAndMask = n & mask;
            int bit = numAndMask >> pos;

            if (bit > 0)
            {
                Console.WriteLine($"bit {n} at pos {pos} is 1");
            }
            else
            {
                Console.WriteLine($"bit {n} at pos {pos} is 0");
            }
        }
    }
}
