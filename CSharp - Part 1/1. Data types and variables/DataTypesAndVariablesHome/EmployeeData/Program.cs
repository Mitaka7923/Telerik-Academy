//A marketing company wants to keep record of its employees. Each record would have the following characteristics:
//    First name
//    Last name
//    Age (0...100)
//    Gender (m or f)
//    Personal ID number (e.g. 8306112507)
//    Unique employee number (27560000â€¦27569999)
//Declare the variables needed to keep the information for a single employee using appropriate primitive 
//data types. Use descriptive names. Print the data at the console.

using System;
using System.Collections.Generic;

namespace EmployeeData
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            string firstName = "Dimitar";
            string lastName = "Sideris";
            byte age = 15;
            string gender = "M";
            string personalIdNumber = "8306112507";
            string uniqueEmployeeNumber = "27560000â€¦27569999";

            Console.WriteLine($"First name: {firstName}");
            Console.WriteLine($"Last name: {lastName}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Gender: {gender}");
            Console.WriteLine($"Personal ID number: {personalIdNumber}");
            Console.WriteLine($"Unique employee number: {uniqueEmployeeNumber}");
        }
    }
}
