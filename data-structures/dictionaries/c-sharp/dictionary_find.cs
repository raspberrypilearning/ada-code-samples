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
                { "days", "14" },
                { "country", "United Arab Emirates" }
            };

            // Ask the user for a key to find
            Console.WriteLine("Enter a key to find:");
            string inputKey = Console.ReadLine();

            // Check if the key exists in the dictionary
            if (astronaut.ContainsKey(inputKey)) {
                Console.WriteLine("Key exists!");
                string value = astronaut[inputKey];
                Console.WriteLine($"Key: {inputKey}, value: {value}");
            }
            else {
                Console.WriteLine("That key does not exist");
            }
        }
    }
}