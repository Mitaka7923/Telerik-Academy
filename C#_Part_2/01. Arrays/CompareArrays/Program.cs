// Problem 2: Compare arrays
// Write a program that reads two integer arrays from the console and compares them element by element.

Console.Write("How many elements do you want to have: ");
int count = int.Parse(Console.ReadLine()!);

// Alocating the arrays with the specified by the user count of elements
int[] array1 = new int[count];
int[] array2 = new int[count];

// Setting array values
for (int i = 0; i < count; i++)
{
    Console.Write($"Enter {i + 1} element of the first array: ");
    array1[i] = int.Parse(Console.ReadLine()!);
}
Console.Clear();
for (int i = 0; i < count; i++)
{
    Console.Write($"Enter {i + 1} element of the second array: ");
    array2[i] = int.Parse(Console.ReadLine()!);
}

Console.Clear();

// Comparing the arrays 
for (int i = 0; i < count; i++)
{
    if (array1[i].Equals(array2[i]))
    {
        Console.WriteLine($"[{i + 1}] element of first array [{array1[i]}] IS equal to the [{i + 1}] element of the second array [{array2[i]}]");
    }
    else
    {
        Console.WriteLine($"[{i + 1}] element of first array [{array1[i]}] IS NOT equal to the [{i + 1}] element of the second array [{array2[i]}]");
    }
}