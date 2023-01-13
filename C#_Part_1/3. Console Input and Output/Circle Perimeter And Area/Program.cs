// Write a program that reads the radius r of a circle and prints its perimeter and area 
// formatted with 2 digits after the decimal point.

using System;

namespace Circle_Perimeter_And_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the radius of the circle:"); 
            double radius = double.Parse(Console.ReadLine());
            double area = Math.PI * Math.Pow(radius, 2);
            double perimeter = 2 * Math.PI * radius;

            Console.WriteLine($"\nArea of the circle: {area:F2}" +
                              $"\nPerimeter of the circle: {perimeter:F2}");
        }
    }
}
