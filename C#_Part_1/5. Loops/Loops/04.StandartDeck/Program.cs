/* Problem 4: Deck of cards
   Write a program that generates and prints all possible cards from a standard deck of 
   52 cards (without the jokers). The cards should be printed using the classical notation 
   (like 5♠, A♥, 9♣ and K♦). The card faces should start from 2 to A. Print each card face 
   in its four possible suits: clubs, diamonds, hearts and spades. Use 2 nested for-loops and 
   a switch-case statement. */


Console.BackgroundColor = ConsoleColor.Gray;
Console.ForegroundColor = ConsoleColor.Black;
Console.WriteLine(@$"                                                   DECK OF CARDS                                                        {Environment.NewLine}");
Console.BackgroundColor = ConsoleColor.Black;
Console.ForegroundColor = ConsoleColor.Gray;

for (int cards = 2; cards <= 10; cards++)
{
    for (int suites = 1; suites <= 4; suites++)
    {
        Thread.Sleep(350);
        switch (suites)
        {
            case 1:
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write($"{cards} ");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.Write("of ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("hearts");
                Console.ForegroundColor = ConsoleColor.Gray;
                break;
            case 2:
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write($"{cards} ");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.Write("of ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("diamonds");
                Console.ForegroundColor = ConsoleColor.Gray;
                break;
            case 3:
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write($"{cards} ");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.Write("of ");
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.Write("spades");
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine();
                break;
            case 4:
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write($"{cards} ");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.Write("of ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("clubs");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine();
                break;
            default:
                break;
        }
    }
}

string[] faceCards = { "Jack", "Queen", "King", "Ace" };
for (int cards = 0; cards <= 3; cards++)
{
    for (int suites = 0; suites < 4; suites++)
    {
        Thread.Sleep(350);
        switch (suites)
        {
            case 0:
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write($"{faceCards[cards]} ");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.Write("of ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("hearts");
                Console.ForegroundColor = ConsoleColor.Gray;
                break;
            case 1:
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write($"{faceCards[cards]} ");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.Write("of ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(" diamonds");
                Console.ForegroundColor = ConsoleColor.Gray;
                break;                         
            case 2:
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write($"{faceCards[cards]} ");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.Write("of ");
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.Write($"spades");
                Console.BackgroundColor = ConsoleColor.Black;
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Gray;
                break;                         
            case 3:
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write($"{faceCards[cards]} ");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.Write("of ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("clubs");
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine();
                break;
            default:
                break;
        }
    }
}