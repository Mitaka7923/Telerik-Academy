//Declare two integer variables a and b and assign them with 5 and 10 and after that 
//exchange their values by using some programming logic.
//Print the variable values before and after the exchange.

using System;

namespace ExchangeVariableValues
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 999;
            int b = 0;
            int changeHelper;
            
            changeHelper = a;
            a = b;
            b = changeHelper;

            Console.WriteLine("A = " + a);
            Console.WriteLine("B = " + b);

            //Initial try - failed
            //int a = 999;
            //int b = 0;
            //Console.WriteLine("Before swap " + a + " and " + b);
            //a = a * b;
            //b = a / b;
            //a = a / b;
            //Console.WriteLine("After swap " + a + " and " + b);
        }
    }
}
