//Problem 1
//Declare five variables choosing for each of them the most appropriate of the 
//types byte, sbyte, short, ushort, int, uint, long, ulong to represent the 
//following values: 52130, -115, 4825932, 97, -10000.
//Choose a large enough type for each number to ensure it will fit in it. Try to compile the code.

using System;

namespace DataTypesAndVariablesHome
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Collecting data.....");
            byte employees = 97;
            sbyte expences = -115;
            short money = -10000;
            ushort panels = 52130;
            int profit = 4825932;

            Console.WriteLine($"Employees: {employees} \n" +
                              $"Solar panels: {panels} \n" +
                              $"Monthly expences: {expences}$ \n" +
                              $"Money in the bank: {money}$ \n" +
                              $"Total profit: {profit}$ \n");
        }
    }
}
