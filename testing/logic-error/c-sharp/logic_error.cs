/*
Raspberry Pi Foundation
Developed as part of Ada Computer Science 
Usage licensed under CC BY-NC-SA 4.0

Note: This file is designed to be copied out and compiled on your machine.
In order for it to compile properly you need to ensure that the project name is the same as the "namespace" in this file.
To run this file you need to:
1. Copy the contents
2. Paste them into the C# IDE of your choice (Microsoft Visual Studio, for example)
3. Change the namespace to match your project (if necessary)
4. Compile the program
5. Run the program
*/

using System;

namespace AdaCodeSamples
{
    class LogicErrors
    {
        // The Main method is the entry point for all C# programs
        public static void Main()
        {
            double amount = 130.40;
            double result = AddVat(amount);
            Console.WriteLine(result);
        }


        // Calculates and applies VAT at standard rate
        public static double AddVat(double amount)
        {
            // Demonstrates a logic error
            int RATE = 20;
            double vat = amount * RATE;
            double withVat = amount + vat;
            return withVat;
        }


    }
}