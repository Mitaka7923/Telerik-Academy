//Declare an integer variable and assign it with the value 254 in hexadecimal format (0x##).
//Use Windows Calculator to find its hexadecimal representation.
//Print the variable and ensure that the result is 254.

using System;
using System.Threading;

namespace VariableInHexadecimalFormat
{
    // Please format your code (Ctrl + K + D). Remove empty line if/else
    // Return is redundant :)
    class Program
    {
        static void Main(string[] args)
        {
            int books = 0xFE;
            Console.WriteLine("Ensuring calculations are correnct...");

            if (books == 254)
            {
                Console.WriteLine($"Task Completed: {books}");
            }
            else
            {
                Console.WriteLine($"Task Failed to complete...please check if {books} = 254 and try again...");
            }
        }
    }
}
