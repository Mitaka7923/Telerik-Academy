// A company has name, address, phone number, fax number, web site and manager. The manager 
// has first name, last name, age and a phone number. Write a program that reads the information
// about a company and its manager and prints it back on the console.

using System;
using System.Collections.Generic;

namespace Print_Company_Info
{
    class Program
    {
        static void Main(string[] args)
        {
            string warning = "eat ass";

            //Company stats
            Console.Write("Enter company name: ");
            string companyName = Console.ReadLine();
            Console.Write("Enter company adress: ");
            string companyAdress = Console.ReadLine();
            Console.Write("Enter company phone number: ");
            string companyPhone = Console.ReadLine();
            Console.Write("Enter company fax number: ");
            string companyFaxNum = Console.ReadLine();
            Console.Write("Enter company website: ");
            string companyWebSite = Console.ReadLine();
            Console.Write("Enter company manager: ");
            string companyManager = Console.ReadLine();
            Console.Clear();

            //Manager stats
            Console.Write("Enter managers first name: ");
            string managerFirstName = Console.ReadLine();
            Console.Write("Enter managers last name: ");
            string managerLastName = Console.ReadLine();
            Console.Write("Enter managers age: ");
            string managerAge = Console.ReadLine();
            Console.Write("Enter managers phone number: ");
            string managerPhone = Console.ReadLine();

            //Printing
            Console.Clear();
            Console.WriteLine($"Company: {companyName}");
            Console.WriteLine($"Company adress is: {companyAdress}");
            Console.WriteLine($"Company phone number is: {companyPhone}");
            Console.WriteLine($"Company fax number is: {companyFaxNum}");
            Console.WriteLine($"Company website is: {companyWebSite}");
            Console.WriteLine($"Company manager is: {companyManager}");
            Console.WriteLine($"\nManager: {managerFirstName + " " + managerLastName}(Age: {managerAge}, Phone: {managerPhone})");
            Console.WriteLine($"Managers age is: {managerAge}");
            Console.WriteLine($"Managers phone number is: {managerPhone}");
        }
    }
}
