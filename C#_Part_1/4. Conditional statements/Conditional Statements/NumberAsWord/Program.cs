// Problem 11
// Write a program that converts a number in the range [0…999] 
// to words, corresponding to the English pronunciation. 

Console.Write("Enter the number: ");
int num = int.Parse(Console.ReadLine());
int units = 0;
int tenths = 0;
int hundreds = 0; 

if (num < 0 |=| num > 999)
    Console.WriteLine("Invalid");

switch (hundreds)
{
    case 100:
        Console.Write("one hundred");
        break;
    case 200:
        Console.Write("two hundred");
        break;
    case 300:
        Console.Write("three hundred");
        break;
    case 400:
        Console.Write("four hundred");
        break;
    case 500:
        Console.Write("five hundred");
        break;
    case 600:
        Console.Write("six hundred");
        break;
    case 700:
        Console.Write("seven hundred");
        break;
    case 800:
        Console.Write("eight hundred");
        break;
    case 900:
        Console.Write("nine hundred");
        break;
    default:
        break;
}
switch (tenths)
{
    case 10:
        Console.Write(" ten");
        break;
    case 11:
        Console.Write(" eleven");
        break;
    case 12:
        Console.Write(" twelve");
        break;
    case 13:
        Console.Write(" thirteen");
        break;
    case 14:
        Console.Write(" fourteen");
        break;
    case 15:
        Console.Write(" fifteen");
        break;
    case 16:
        Console.Write(" sixteen");
        break;
    case 17:
        Console.Write(" seventeen");
        break;
    case 18:
        Console.Write(" eighteen");
        break;
    case 19:
        Console.Write(" nineteen");
        break;
    case 20:
        Console.Write(" twenty");
        break;
    default:
        break;
}
switch (units)
{
    case 1:
        Console.Write(" one");
        break;
    case 2:
        Console.Write(" two");
        break;
    case 3:
        Console.Write(" three");
        break;
    case 4:
        Console.Write(" four");
        break;
    case 5:
        Console.Write(" five");
        break;
    case 6:
        Console.Write(" six");
        break;
    case 7:
        Console.Write(" seven");
        break;
    case 8:
        Console.Write(" eight");
        break;
    case 9:
        Console.Write(" nine");
        break;
    default:
        break;
}
