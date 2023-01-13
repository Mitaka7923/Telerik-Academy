//Problem 12. Extract Bit from Integer
//Write an expression that extracts from given integer n the value of given bit at index p.

using System;

namespace ExtractBitfromInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int index = int.Parse(Console.ReadLine());

            int mask = 1 << index;
            int numAndMask = num & mask;
            int bit = numAndMask >> index;

            Console.WriteLine(bit);
        }
    }
}
