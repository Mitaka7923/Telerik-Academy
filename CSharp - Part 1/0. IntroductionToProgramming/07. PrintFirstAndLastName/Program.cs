// Problem 7: Print First and Last Name
// Create console application that prints your first and last name, each at a separate line.

Console.Write("What is your first name: ");
string firstName = Console.ReadLine();
Console.Write("What is your last name: ");
string lastName = Console.ReadLine();
string name = firstName + " " + lastName;

Console.WriteLine($"Printing your name {name}.");