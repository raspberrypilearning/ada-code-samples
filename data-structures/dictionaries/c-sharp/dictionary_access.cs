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
using System.Collections.Generic;

namespace AdaCodeSamples {
    class SingleDictionaries {
        // The Main method is the entry point for all C# programs
        public static void Main() {
            // Declare and initialise the astronaut dictionary
            Dictionary<string, string> astronaut = new Dictionary<string, string>() {
                { "craft", "ISS" },
                { "name", "Sultan Al Neyadi" },
                { "days", "14" }
            };

            // Output the name and spacecraft
            string name = astronaut["name"];
            string spacecraft = astronaut["craft"];
            Console.WriteLine($"Astronaut {name} is on the {spacecraft}");
        }
    }
}