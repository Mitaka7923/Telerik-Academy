// Problem 10. Point Inside a Circle & Outside of a Rectangle
// Write an expression that checks for given point (x, y) if it is within the circle 
// K({1, 1}, 1.5) and out of the rectangle R(top=1, left=-1, width=6, height=2).

using System;

namespace InsideCircleAndOutsideRectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            const string circle = "K({1, 1}, 1.5)";
            const string rectangle = "R(top=1, left=-1, width=6, height=2)";
            Console.Write("Enter value for X: ");
            double x = double.Parse(Console.ReadLine());
            Console.Write("Enter value for Y: ");
            double y = double.Parse(Console.ReadLine());
            bool isInside = (x * x) + (y * y) <= 2 * 2 ? true : false;

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
