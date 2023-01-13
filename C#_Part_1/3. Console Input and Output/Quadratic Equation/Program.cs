// Write a program that reads the coefficients a, b and c of a quadratic equation ax2 + bx + c = 0 and solves it (prints its real roots).

using System;

namespace Quadratic_Equation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter coefficient a: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Enter coefficient b: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Enter coefficient c: ");
            double c = double.Parse(Console.ReadLine());

            double D = Math.Pow(b, 2) - 4 * a * c;
            if (D < 0)
            {
                Console.WriteLine($"The equasion {a}x² + {b}x + {c} = 0 has no real roots.");
            }
            else if (D == 0)
            {
                double x = -b / (2 * a);
                Console.WriteLine($"The equasion {a}x² + {b}x + {c} = 0 has one real root: x1 = x2 = {x}.");
            }
            else
            {
                double x1 = ((-b + Math.Sqrt(D)) / (2 * a));
                double x2 = ((-b - Math.Sqrt(D)) / (2 * a));
                Console.WriteLine("The equasion {a}x² + {b}x + {c} = 0 has two real roots: X1 = {0} \nX2 = {1}", x1, x2);
            }
        }
    }
}
