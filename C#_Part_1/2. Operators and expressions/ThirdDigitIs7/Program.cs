// Problem 5
// Write an expression that checks for given integer if its third digit from right-to-left is 7.
// Note: need to make it reversed but will leave it for later

using System;

namespace ThirdDigitIs7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a number: ");
            int input = int.Parse(Console.ReadLine());
            int thirdDigit = (input / 100) % 10;

            if (input <= 99)
            {
                Console.WriteLine("INVALID VALUE...TRY AGAIN!!!");
            }
            else if (thirdDigit == 7)
            {
                Console.WriteLine("Third digit is seven!");
            }
            else
            {
                Console.WriteLine("Third digit is not seven!");
            }
        }
    }
}
