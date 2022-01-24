// Problem 9. Trapezoids
// Write an expression that calculates trapezoid's area by given sides a and b and height h.

using System;
using System.Threading;

namespace Trapezoids
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Please enter side A: ");
                string a = Console.ReadLine();
                Console.Write("Please enter side B: ");
                string b = Console.ReadLine();
                Console.Write("Please enter height: ");
                string h = Console.ReadLine();

                string warning = "WARNING!!! PLEASE ENTER A POSITIVE INTEGER OR A FLOATING POINT! CONTINUE? ";

                if (!double.TryParse(a, out double doubleA) || !double.TryParse(b, out double doubleB) || !double.TryParse(h, out double doubleH) || doubleA < 0 || doubleB < 0 || doubleH < 0)
                {
                    Console.Clear();
                    Console.Write(warning);
                    ConsoleKeyInfo inputKey = Console.ReadKey();
                    if (inputKey.Key == ConsoleKey.Y)
                    {
                        Console.Clear();
                        Console.WriteLine("Please wait...");
                        Thread.Sleep(800);
                        Console.Clear();
                        continue;
                    }
                    else if (inputKey.Key == ConsoleKey.N)
                    {
                        Console.Clear();
                        Console.WriteLine("Please wait...");
                        Thread.Sleep(300);
                        return;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("I DID NOT UNDERSTAND.");
                        break;
                    }
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine($"TRAPEZOID AREA IS: {(doubleA + doubleB) / 2 * doubleH}");
                }

                Console.Write("Press (1) if you want to see your parameters or press (ANY KEY) to exit...");
                ConsoleKeyInfo input = Console.ReadKey();
                if (input.Key == ConsoleKey.D1)
                {
                    Console.Clear();
                    Console.WriteLine($"Side A: {doubleA}");
                    Console.WriteLine($"Side B: {doubleB}");
                    Console.WriteLine($"Height: {doubleH}");
                    Console.WriteLine($"Area's: {(doubleA + doubleB) / 2 * doubleH}");
                }
                else
                {
                    Console.Clear();
                    break;
                }
            }
        }
    }
}