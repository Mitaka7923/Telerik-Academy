// Problem 5: Maximal increasing sequence
// Write a program that finds the maximal increasing sequence in an array.

using System;

namespace _05._MaximalIncreaingSequence
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter array: ");
            var inputArray = Console.ReadLine()!.Split(',', ' ').ToArray();
            var array = new int[inputArray.Length];
            var maxSequence = 1;
            var currentSeq = 1;
            var numbers = new List<int>();
            var maxNumbers = new List<int>();

            for (int i = 0; i < inputArray.Length; i++)
            {
                if (!int.TryParse(inputArray[i], out int currentNumber))
                {
                    Console.WriteLine("ERROR");
                    return;
                }

                array[i] = currentNumber;
            }

            //for (int i = 0; i < array.Length; i++)
            //{
            //    if (i != array.Length - 1)
            //    {
            //        if (array[i] + 1 == array[i + 1])
            //        {
            //            numbers.Add(array[i]);
            //            currentSeq++;

            //            if (currentSeq > maxSequence)
            //            {
            //                maxSequence = currentSeq;
            //                numbers.ForEach(x => maxNumbers.Add(x));
            //            }

            //            numbers.Clear();
            //        }
            //        else
            //        {
            //            if (currentSeq > 1)
            //            {
            //                maxNumbers.Add(array[i]);
            //            }

            //            currentSeq = 1;
            //        }
            //    }
            //    else
            //    {
            //        if (array[i] > array[i - 1])
            //        {
            //            maxNumbers.Add(array[i]);
            //        }
            //    }
            //}

            //[1,222,3,4,1,2]

            for (int i = 0; i < array.Length - 1; i+=2)
            {
                var currentNumber = array[i];
                var nextNumber = array[i + 1];

                if(currentNumber + 1 == nextNumber)
                {
                    numbers.Add(currentNumber);
                    numbers.Add(nextNumber);
                }
                else
                {
                    numbers.Clear();
                    i--;
                }
            }

            Console.WriteLine($"Maximum increasing sequence: {String.Join(", ", numbers)}");
        }
    }
}