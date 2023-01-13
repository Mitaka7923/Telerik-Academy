// Problem 1
// Write an if-statement that takes two integer variables a and b and exchanges 
// their values if the first one is greater than the second one. As a result 
// print the values a and b, separated by a space.

Console.Write("Please enter a: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Please enter b: ");
int b = int.Parse(Console.ReadLine());
int helperA = a;

if (a > b)
{
    a = b;
    b = helperA;
}

Console.WriteLine($"\n{a} {b}");