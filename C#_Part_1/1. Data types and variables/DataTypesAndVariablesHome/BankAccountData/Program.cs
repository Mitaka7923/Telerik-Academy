//A bank account has a holder name (first name, middle name and last name), available amount of money
//(balance), bank name, IBAN, 3 credit card numbers associated with the account.
//Declare the variables needed to keep the information for a single bank account using the appropriate 
//data types and descriptive names.

using System;
using System.Collections.Generic;

namespace BankAccountData
{
    class Program
    {
        static void Main(string[] args)
        {   
            Console.WriteLine(@"Bank Account log retrieving...in progress...");

            var bankAccounts = new List<BankAccount>();
            for (int i = 0; i < 100; i++)
            {
                var bankAccount = new BankAccount();
                    bankAccount.FirstName = $"Dimitar {i}";
                    bankAccount.LastName = $"Sideris {i}";
                    bankAccount.MiddleName = $"Liybenov {i}";
                    bankAccount.Balance = i;
                    bankAccount.IBAN = $"BG19BNPA944084347438{i}";
                    bankAccount.BankName = "FiBank";
                    bankAccount.LinkedCards = new List<CreditCard>();
                    bankAccount.LinkedCards.Add(new CreditCard($"4988317361495{i}1"));
                    bankAccount.LinkedCards.Add(new CreditCard($"4988317361495{i}2"));
                    bankAccount.LinkedCards.Add(new CreditCard($"4988317361495{i}3"));
                    bankAccounts.Add(bankAccount);
            }
            for (int i = 0; i < bankAccounts.Count; i++)
            {
                var bankAccount = bankAccounts[i];
                    Console.WriteLine($"First name: {bankAccount.FirstName}");
                    Console.WriteLine($"Middle name: {bankAccount.MiddleName}");
                    Console.WriteLine($"Last name: {bankAccount.LastName}");
                    Console.WriteLine($"Available Balance: {bankAccount.Balance}");
                    Console.WriteLine($"Bank name: {bankAccount.BankName}");
                    Console.WriteLine($"IBAN: {bankAccount.IBAN}");
                    Console.WriteLine();
            }
        }
    }
}
