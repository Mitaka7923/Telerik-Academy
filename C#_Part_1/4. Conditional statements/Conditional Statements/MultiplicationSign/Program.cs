// Problem 4
// Write a program that shows the sign (+, - or 0) of the product of three real 
// numbers, without calculating it. Use a sequence of if operators.

try
{
    Console.Write("Enter a: ");
    int a = int.Parse(Console.ReadLine());
    Console.Write("Enter b: ");
    int b = int.Parse(Console.ReadLine());
    Console.Write("Enter c: ");
    int c = int.Parse(Console.ReadLine());

    if (a == 0 && b == 0 && c == 0)
    {
        Console.WriteLine("0");
    }
    else if (a > 0 && b > 0 && c > 0)
    {
        Console.WriteLine("+");
    }
    else if (a < 0 || b < 0 || c < 0)
    {
        Console.WriteLine("-");
    }
}
catch (Exception)
{
    Console.WriteLine("No comprende formatte....");
}