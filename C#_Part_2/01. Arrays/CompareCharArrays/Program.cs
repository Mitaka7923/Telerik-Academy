// Problem 3: Compare char arrays
// Write a program that compares two char arrays lexicographically (letter by letter).

Console.Write("Enter first array of characters: ");
string arr1 = Console.ReadLine();
Console.Write("Enter second array of characters: ");
string arr2 = Console.ReadLine();
int length = 0;
int maxLength = 0;

if (arr1.Length >= arr2.Length)
{
    length = arr2.Length;
    maxLength = arr1.Length;
}
else
{
    length = arr1.Length;
    maxLength = arr2.Length;
}
for (int i = 0; i < length; i++)
{
    if (arr1[i] == arr2[i])
    {
        Console.WriteLine($"{i} element [{arr1[i]}] = {i} element [{arr2[i]}]");
    }
    else
    {
        Console.WriteLine($"{arr1[i]} != {arr2[i]}");
    }
}
Console.WriteLine($"Not equal count for {maxLength - length} elements. One is bigger...");