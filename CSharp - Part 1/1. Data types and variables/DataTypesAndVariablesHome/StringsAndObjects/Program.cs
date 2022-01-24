//Declare two string variables and assign them with Hello and World.
//Declare an object variable and assign it with the concatenation of the first two variables (mind adding an interval between).
//Declare a third string variable and initialize it with the value of the object variable (you should perform type casting).

using System;

namespace StringsAndObjects
{
    class Program
    {
        // Please try to name your variables better so a person with no context can understand by their names
        static void Main(string[] args)
        {   
            //After naming variables better
            string greeting1 = "Hello";
            string greeting2 = "World";
            object greeting = greeting1 + " " + greeting2;
            string sentance = (string)greeting;
            Console.WriteLine(sentance);
        }
    }
}
