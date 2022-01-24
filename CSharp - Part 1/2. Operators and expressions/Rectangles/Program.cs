// Problem 4 -
// Write an expression that calculates rectangle’s perimeter and area by given width and height. 

using System;

namespace Rectangles
{
    class Program
    {
        static void Main(string[] args)

        {
            { 
                Console.Write("Enter rectangle widgh: ");
                string width = Console.ReadLine();
                Console.Write("Enter rectangle Height: ");
                string height = Console.ReadLine();
                string warning = "WARNING !!! Please enter a positive integer or floating point number and try again!";

                if (!decimal.TryParse(width, out decimal decimalWidth) || !decimal.TryParse(height, out decimal decimalHeight))
                {
                    Console.WriteLine(warning);
                    return;
                }
                else if (decimalWidth < 0)
                {
                    Console.Clear();
                    Console.WriteLine(warning);
                    return;
                }
                else if (decimalHeight < 0)
                {
                    Console.Clear();
                    Console.WriteLine(warning);
                    return;
                }
                else
                {
                    decimal area = decimalWidth * decimalHeight;
                    decimal perimeter = decimalWidth * 2 + decimalHeight * 2;
                    area = Math.Round(area, 2);
                    perimeter = Math.Round(perimeter, 2);
                    //Could easily inplement the ecuasion in the string but the assignment to a variable is more optimal
                    Console.WriteLine($"\nThe area of the rectangle is: {area}");
                    Console.WriteLine($"The perimeter of the rectangle is: {perimeter}");
                }
            }
        }
    }
}