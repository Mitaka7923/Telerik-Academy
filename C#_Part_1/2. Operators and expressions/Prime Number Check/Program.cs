// Write an expression that checks if given positive integer number n (n = 100) is prime
// (i.e. it is divisible without remainder only to itself and 1).
// 3, 5, 7, 11 (9 is divisible by 3) and so on, always dividing by a prime number (see table below).
using System;

namespace Prime_Number_Check
{
    class Program
    {
        // Here we only check if the number can be divided by itself and 1 but we dont check for the other numbers....we might need a loop for
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int num = int.Parse(Console.ReadLine());
            bool isPrime = true;

            if (num == 1 || num == 0)
            {
                isPrime = false;
            }
            else 
            {
                for (int i = 2; i <= Math.Sqrt(num); i++)
                {
                    if (num % i == 0)
                    {
                        isPrime = false;
                    }
                }
            }
            if (isPrime == true)
            {
                Console.WriteLine($"The num {num} is PRIME.");
            }
            else
            {
                Console.WriteLine($"The num {num} is not PRIME.");
            }


        }
    }
}