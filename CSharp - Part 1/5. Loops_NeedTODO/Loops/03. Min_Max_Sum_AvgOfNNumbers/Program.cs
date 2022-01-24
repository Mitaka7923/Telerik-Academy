// Problem 3
// Write a program that reads from the console a sequence of n integer numbers 
// and returns the minimal, the maximal number, the sum and the average of all numbers 
// (displayed with 2 digits after the decimal point). The input starts by the number n 
// (alone in a line) followed by n lines, each holding an integer number.

int inputNumber;
string input;
int min = 0;
int max = 0;
double sum = 0;
double average = 0;
List<int> numbers = new List<int>();

do
{
    Console.Clear();
    Console.Write("How much numbers do you want to use: ");
    input = Console.ReadLine();
} while (!int.TryParse(input, out inputNumber));

for (int i = 1; i <= inputNumber; i++)
{
    Console.Write($"Enter {i} number : ");
    numbers.Add(int.Parse(Console.ReadLine()));
}

for (int i = 0; i < numbers.Count; i++)
{
    sum += numbers[i];
}

average = (double)(sum / numbers.Count);

Console.WriteLine($"Min: {min}");
Console.WriteLine($"Max: {max}");
Console.WriteLine($"Sum: {sum}");
Console.WriteLine($"Average: {average:F2}");