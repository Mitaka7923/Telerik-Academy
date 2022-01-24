// Problem 2: Compare arrays
// Write a program that reads two integer arrays from the console and compares them element by element.

Console.Write("How many elements do you want to have: ");
int count = int.Parse(Console.ReadLine());
int[] array1 = new int[count];
int[] array2 = new int[count];

for (int i = 0; i < count; i++)
{
    Console.Write($"Enter {i} element of the first array: ");
    array1[i] = int.Parse(Console.ReadLine());
}
Console.Clear();
for (int i = 0; i < count; i++)
{
    Console.Write($"Enter {i} element of the second array: ");
    array2[i] = int.Parse(Console.ReadLine());
}
Console.Clear();
for (int i = 0; i < count; i++)
{
    if (array1[i] == array2[i])
    {
        Console.WriteLine($"{i} element [{array1[i]}] = {i} element [{array2[i]}]");
    }
    else
    {
        Console.WriteLine($"{array1[i]} != {array2[i]}");
    }
}