// Problem 11. Bitwise: Extract Bit #3
// Using bitwise operators, write an expression for finding the value of the bit #3 of a given unsigned integer.
// The bits are counted from right to left, starting from bit #0.
// The result of the expression should be either 1 or 0.

using System;

namespace BitWise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            uint num = uint.Parse(Console.ReadLine());
            int pos = 3;              
            uint toRight = num >> pos;
            uint bit = toRight & 1;
            Console.WriteLine(bit);
        }
    }
}
