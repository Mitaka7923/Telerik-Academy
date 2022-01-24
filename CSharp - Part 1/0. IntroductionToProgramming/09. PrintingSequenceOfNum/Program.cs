// Problem 9: Print a Sequence
// Write a program that prints the first 10 members of the sequence: 2, -3, 4, -5, 6, -7, ...

for (int i = 2; i <= 10; i++)
{
    if (i % 2 == 0)
    {
        Console.Write(i);
    }
    if (i % 2 != 0)
    {
        Console.Write($"-{i}");
    }
    if (i != i + 1)
    {
        Console.Write(",");
    }
    else if (i == i + 1)
    {
        Console.ReadKey(true);
    }
}