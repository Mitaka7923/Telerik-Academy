// Write a program that enters a number n and after that enters more n numbers 
// and calculates and prints their sum. Note that you may need to use a for-loop.

using System;
using System.Threading;
using System.Text;
using System.Collections.Generic;

namespace Sum_Of_N_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo exitKey = default;
            string warning = "ENTER VALID NUMBER....";
            string waiting = ".";
            char smile = '\u263A';
            int multiplier = 2;
            int count = default;
            double sum = default;

            while (true)
            {
                count++;
                if (count > 3)
                {
                    Console.WriteLine("YOU TRIED TOO MUCH TIMES....EXITING NOW!");
                    Console.WriteLine("\r\n" + @"▄██████████████▄▐█▄▄▄▄█▌" +
                                      "\r\n" +  "██████▌▄▌▄▐▐▌███▌▀▀██▀▀" + 
                                      "\r\n" +  "████▄█▌▄▌▄▐▐▌▀███▄▄█▌" + 
                                      "\r\n" +  "▄▄▄▄▄██████████████▀");
                    break;
                }
                Console.Write("Enter how much numbers you will concetanate: ");
                string number = Console.ReadLine();
                bool parsed = double.TryParse(number, out double numberParsed);

                if (parsed != true || numberParsed < 2)
                {
                    Console.Clear();
                    Console.Write(warning);
                    Thread.Sleep(550);
                    Console.Write("Press (1) to TRY again OR ANY key to EXIT");
                    exitKey = Console.ReadKey();
                    Console.Clear();
                    if (exitKey.Key == ConsoleKey.D1)
                        continue;
                    else
                        break;
                }
                else
                {
                    for (int i = 0; i < numberParsed; i++)
                    {
                        Console.Write("Enter a number: ");
                        sum += double.Parse(Console.ReadLine());
                    }
                    if (sum < 2)
                    {
                        for (int i = 0; i < 4; i++)
                        {
                            string result = string.Join(waiting, new string[multiplier + i]);
                            Console.Write($"\rNo point{result}");
                            Thread.Sleep(500);
                        }
                        Console.Clear();
                        Console.WriteLine("\n" + @"█▄▄ █▄█ █▀▀   █▄▄ █▄█ █▀▀" +
                                         "\n\r" + "█▄█ ░█░ ██▄   █▄█ ░█░ ██▄");
                        break;
                    }
                    else
                    {
                        Console.Clear();
                        for (int i = 0; i < 4; i++)
                        {
                            string result = string.Join(waiting, new string[multiplier + i]);
                            Console.Write($"\rCALCULATING{result}");
                            Thread.Sleep(400);
                        }
                        Console.Clear();
                        Console.WriteLine($"The sum of {numberParsed} numbers is {sum}");
                        Thread.Sleep(700);
                        Console.WriteLine($"Thank you! I hope I see your numbers again soon!{smile}");
                    }
                }
                break;
            }
        }
    }
}
