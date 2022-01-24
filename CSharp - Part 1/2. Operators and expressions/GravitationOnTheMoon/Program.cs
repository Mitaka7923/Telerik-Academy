// Problem 2 - 
// The gravitational field of the Moon is approximately 17% of that on the Earth. 
// Write a program that calculates the weight of a man on the moon by a given weight
// on the Earth.

using System;

namespace GravitationOnTheMoon
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Earth weight: ");
            double weight = double.Parse(Console.ReadLine());

            if ((weight > 0) && (weight < 230))    
            {
                Console.WriteLine($"Moon weight: {weight - (weight * 0.17)}");
            }
            else
            {
                Console.WriteLine("INVALID VALUE....TRY AGAIN!!!");
            }
        }
    }
}