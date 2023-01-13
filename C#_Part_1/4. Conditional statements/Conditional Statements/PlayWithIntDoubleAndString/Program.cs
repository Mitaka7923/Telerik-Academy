// Problem 9
// Write a program that, depending on the user’s choice, inputs an int, 
// double or string variable. If the variable is int or double, the program 
// increases it by one. If the variable is a string, the program appends "*" 
// at the end. Print the result at the console. Use switch statement. */

Console.WriteLine("1. Int ------ 2. Double ------ 3. String");
int input = int.Parse(Console.ReadLine());

switch (input)
{
    case 1:
        Console.Clear();
        Console.Write("Enter the number: ");
        int inputInt = int.Parse(Console.ReadLine());
        inputInt++;
        Console.WriteLine($"Result is: {inputInt}");
        break;
    case 2:
        Console.Clear();
        Console.Write("Enter the number: ");
        double intputDouble = double.Parse(Console.ReadLine());
        intputDouble++;
        Console.WriteLine($"Result is: {intputDouble}");
        break;
    case 3:
        Console.Clear();
        Console.Write("Enter the string: ");
        string inputString = Console.ReadLine();
        inputString = inputString + "*";
        Console.WriteLine($"Result is: {inputString}");
        break;
    default:
        break;
}