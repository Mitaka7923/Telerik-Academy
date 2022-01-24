// Problem 6
// Write a program that finds the biggest of five numbers.

Console.Write("Enter first number: ");
int num1 = int.Parse(Console.ReadLine());
Console.Write("Enter second number: ");
int num2 = int.Parse(Console.ReadLine());
Console.Write("Enter third number: ");
int num3 = int.Parse(Console.ReadLine());
Console.Write("Enter fourth number: ");
int num4 = int.Parse(Console.ReadLine());
Console.Write("Enter fifth number: ");
int num5 = int.Parse(Console.ReadLine());

int biggerNum = num1;
if (num2 > biggerNum)
    biggerNum = num2;
if (num3 > biggerNum)
    biggerNum = num3;
if (num4 > biggerNum)
    biggerNum = num4;
if (num5 > biggerNum)
    biggerNum = num5;

Console.WriteLine($"The bigger number is: {biggerNum}");