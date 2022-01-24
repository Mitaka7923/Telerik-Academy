// Problem 2
// Write a program that enters from the console a positive integer n 
// and prints all the numbers from 1 to n not divisible by 3 and 7, 
// on a single line, separated by a space.

//Declaring needed variables
string input;
int inputNum;

//Asking for the number
do
{
    Console.Clear();
    Console.Write("Enter a valid number: ");
    input = Console.ReadLine();
} while (!int.TryParse(input, out inputNum));

//Output and logic
for (int value = 1; value <= inputNum; value++)
{
    if (value % 3 != 0 && value % 7 != 0)
        Console.Write($"{value} ");
}