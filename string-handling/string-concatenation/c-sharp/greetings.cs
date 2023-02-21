/*
Raspberry Pi Foundation
Developed as part of Ada Computer Science 
Usage licensed under CC BY-NC-SA 4.0

Note: This file is designed to be copied out and compiled on your machine.
In order for it to compile properly you need to ensure that the project name is the same as the "namespace" in this file.
To run this file you need to:
1. Copy the contents
2. Paste them into the C# IDE of your choice (Visual Studio, for example)
3. Change the namespace to match your project (if necessary)
4. Compile the program
5. Run the program
*/

using System;

namespace AdaCodeSamples
{
    class StringConcatenation
    {
        // The Main method is the entry point for all C# programs
        public static void Main()
        {
            GreetUser();           
        }

        
        // Demonstration of string concatenation
        public static void GreetUser()
        {
            Console.WriteLine("Please enter your first name ");
            string firstName = Console.ReadLine();
            Console.WriteLine("Greetings " + firstName);

            Console.WriteLine("Please enter your last name ");
            string lastName = Console.ReadLine();
            
            string userName = firstName + " " + lastName;
            Console.WriteLine("Greetings " + userName);
        }
        
        
    }
}