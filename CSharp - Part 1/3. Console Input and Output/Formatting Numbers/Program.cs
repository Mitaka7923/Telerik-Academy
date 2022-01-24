// Write a program that reads 3 numbers: an integer a (0 ≤ a ≤ 500), a floating-point b 
// and a floating-point c and prints them in 4 virtual columns on the console. Each column 
// should have a width of 10 characters. The number a should be printed in hexadecimal, left 
// aligned; then the number a should be printed in binary form, padded with zeroes, then the 
// number b should be printed with 2 digits after the decimal point, right aligned; the number 
// c should be printed with 3 digits after the decimal point, left aligned. */

using System;

namespace Formatting_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Integer a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Floatint b: ");
            float b = float.Parse(Console.ReadLine());
            Console.Write("Floatint c: ");
            float c = float.Parse(Console.ReadLine());
            string warning = "Enter a number between 0-500 for A....";

            if (a < 0 || a > 500)
            {
                Console.WriteLine(warning);
                return;
            }
            string binaryA = Convert.ToString(a, 2).PadLeft(10, '0');
            Console.WriteLine("\n|{0, -10 :X}|{1, 10}|{2, 10 :F2}|{3, -10 :F3}|", a, binaryA, b, c);
        }
    }
}
