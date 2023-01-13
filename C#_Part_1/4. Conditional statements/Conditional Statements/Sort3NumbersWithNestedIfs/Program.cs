// Problem 7
// Write a program that enters 3 real numbers and prints them sorted in 
// descending order. Use nested if statements. Don’t use arrays and the built-in 
// sorting functionality.

Console.Write("Enter first number: ");
int num1 = int.Parse(Console.ReadLine());
Console.Write("Enter second number: ");
int num2 = int.Parse(Console.ReadLine());
Console.Write("Enter third number: ");
int num3 = int.Parse(Console.ReadLine());

if (num3 > num1 && num3 > num2)
{
    Console.WriteLine(num3);
    if (num2 > num1)
    {
        Console.WriteLine(num2);
        Console.WriteLine(num1);
    }
    else
    {
        Console.WriteLine(num1);
        Console.WriteLine(num2);
    }
}
if (num2 > num1 && num2 > num3)
{
    Console.WriteLine(num2);
    if (num1 > num3)
    {
        Console.WriteLine(num1);
        Console.WriteLine(num3);
    }
    else 
    {
        Console.WriteLine(num3);
        Console.WriteLine(num1);
    }
}
if (num1 > num2 && num1 > num3)
{
    Console.WriteLine(num1);
    if (num2 > num3)
    {
        Console.WriteLine(num2);
        Console.WriteLine(num3);
    }
    else
    {
        Console.WriteLine(num3);
        Console.WriteLine(num2);
    }
}