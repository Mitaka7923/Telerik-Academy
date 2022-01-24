//Problem 2
//Which of the following values can be assigned to a variable of type float and which to a variable of 
//type double: 34.567839023, 12.345, 8923.1234857, 3456.091?
//Write a program to assign the numbers in variables and print them to ensure no precision is lost.

using System;

namespace FloatOrDuble
{
    class Program
    {
        static void Main(string[] args)
        {
            float numberFirst = 12.345f;
            float numberSecond = 3456.091f;
            double numberThird = 8923.1234857;
            double numberFourth = 34.567839023;

            Console.WriteLine(
$@"Ensuring no precision is lost:
First Number - {numberFirst}
Second Number - {numberSecond}
Third Number - {numberThird}
Fourth Number - {numberFourth}");
        }
    }
}