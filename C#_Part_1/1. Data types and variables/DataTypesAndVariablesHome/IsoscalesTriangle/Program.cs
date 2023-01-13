//Write a program that prints an isosceles triangle of 9 copyright symbols Â©, something like this:
//Note: The Â© symbol may be displayed incorrectly at the console so you may need to change the console character 
//encoding to UTF-8 and assign a Unicode-friendly font in the console.
//Note: Under old versions of Windows the Â© symbol may still be displayed incorrectly, regardless of how much 
//effort you put to fix it.

using System;

namespace IsoscalesTriangle
{
    class Program
    {
        static void Main(string[] args)
        {   

            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine(@"
       ©
      © © 
     ©   ©  
    © © © © 
");
        }
    }
}
