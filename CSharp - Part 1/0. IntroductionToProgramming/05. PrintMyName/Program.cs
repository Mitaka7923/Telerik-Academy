﻿// Problem 5: Print Your Name
// Modify the previous application to print your name.
// Ensure you have named the application well (e.g. “PrintMyName”).
// You should submit a separate project Visual Studio project holding the PrintMyName class as part of your homework.

class PrintMyName
{
    static void Main()
    {
        Console.Write("My name is: ");
        string name = Console.ReadLine();
        Console.WriteLine($"{name} - Greetings!");
    }
}