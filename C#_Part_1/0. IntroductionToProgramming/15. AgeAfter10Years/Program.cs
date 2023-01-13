// Problem 15: * Age after 10 Years
// Write a program to read your birthday from the console and print how old you are now and how old you will be after 10 years.

int age = int.Parse(Console.ReadLine());
int futureAge = age + 10;

Console.WriteLine($"Your age after 10 years is: {futureAge} years old");