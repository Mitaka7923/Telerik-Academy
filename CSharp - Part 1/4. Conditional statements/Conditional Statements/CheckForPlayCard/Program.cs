// Problem 3
// * Classical play cards use the following signs to designate the card face: 
// * 2, 3, 4, 5, 6, 7, 8, 9, 10, J, Q, K and A. Write a program that enters a 
// * string and prints “yes” if it is a valid card sign or “no” otherwise.

Console.Write("Enter the card sign to see if it's valid: ");
string input = Console.ReadLine();

switch (input)
{
    case "2":
    case "3":
    case "4":
    case "5":
    case "6":
    case "7":
    case "8":
    case "9":
    case "10":
    case "j":
    case "J":
    case "q":
    case "Q":
    case "k":
    case "K":
    case "a":
    case "A":
        Console.WriteLine("yes");
        break;
    default:
        Console.WriteLine("no");
        break;
}


///This has the same output, but I initially did it like this.

//int.TryParse(input, out int numCards);
//if ((numCards >= 2 && numCards <= 10) ||
//    input == "J" ||
//    input == "Q" ||
//    input == "K" ||
//    input == "A")
//{
//    Console.WriteLine("yes");
//}
//else
//    Console.WriteLine("no");