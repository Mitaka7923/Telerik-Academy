// Problem 7. Point in a Circle
// Write an expression that checks if given point (x, y) is inside a circle K({0, 0}, 2).
// look in the internet how to define a circle and what is "K({0, 0}, 2)"!!
// Explanation: the point {0, 0} is the center of the circle and 5 is the radius.
// Guidelines: Use the Pythagorean Theorem a2 + b2 = c2. The point is inside the circle when (x*x) +(y * y) ≤ 5 * 5.

using System;

namespace PointInCircle
{
    class Program
    {
        static void Main(string[] args)
        {
            const string circle = "K({0, 0}, 2)";
            Console.Write("Enter value for X: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Enter value for Y: ");
            int y = int.Parse(Console.ReadLine());
            bool isInside = (x * x) + (y * y) <= 2 * 2 ? true : false ;

            if (isInside == true)
            {
                Console.Clear();
                Console.WriteLine($"The point O({x} , {y}) is inside {circle}!");
            }
            else
            {
                Console.Clear();
                Console.WriteLine($"The point O({x} , {y}) is not inside {circle}!");
            }
        }
    }
}
