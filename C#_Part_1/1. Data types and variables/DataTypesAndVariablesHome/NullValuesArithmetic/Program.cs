//Create a program that assigns null values to an integer and to a double variable.
//Try to print these variables at the console.
//Try to add some number or the null literal to these variables and print the result. ????

using System;

namespace NullValuesArithmetic
{
    class Program
    {
        static void Main(string[] args)
        {   
            int? value = null;
            double? secondValue = null;
            Console.WriteLine(value);
            Console.WriteLine(secondValue);
        }
    }
}
