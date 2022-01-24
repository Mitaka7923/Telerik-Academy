// Problem 1
// Write a program that enters from the console a positive integer n 
// and prints all the numbers from 1 to n, on a single line, separated by a space.

int inputNum;
do
{
    Console.Clear();
    Console.WriteLine("Please enter a positive integer for n. ");
    Console.Write("n = ");
    inputNum = int.Parse(Console.ReadLine());
} while (inputNum <= 0);
ConsoleOuput();

void ConsoleOuput()
{
    for (int startingValue = 1; startingValue <= inputNum; startingValue++)
    {
        Thread.Sleep(250);
        Console.Write($"{startingValue} ");
    }
}