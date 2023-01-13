// Problem 5
// Write a program that finds the biggest of three numbers.

Console.Write("Enter first number: ");
int num1 = int.Parse(Console.ReadLine());
Console.Write("Enter second number: ");
int num2 = int.Parse(Console.ReadLine());
Console.Write("Enter third number: ");
int num3 = int.Parse(Console.ReadLine());

int biggerNum = Math.Max(num1, num2);
biggerNum = Math.Max(biggerNum, num3);

Console.WriteLine($"The bigger number is: {biggerNum}");