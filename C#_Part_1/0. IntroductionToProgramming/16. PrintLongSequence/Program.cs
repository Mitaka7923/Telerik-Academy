// Problem 16: * Print Long Sequence
// Write a program that prints the first 1000 members of the sequence: 2, -3, 4, -5, 6, -7, …
// You might need to learn how to use loops in C# (search in Internet).

int numbersToPrint = 1000;

for (int member = 2; member <= numbersToPrint; member++)
{
    if (member % 2 == 0)
    {
        Console.Write(member);
    }
    if (member % 2 != 0)
    {
        Console.Write($"-{member}");
    }
    if (member != numbersToPrint)
    {
        Console.Write(" , ");
    }
    else if (member == numbersToPrint + 1)
    {
        Console.WriteLine();
        Console.ReadKey(true);
    }
}