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
    class SimpleLists {
        // The Main method is the entry point for all C# programs
        public static void Main() {
            // Declare and initialise the astronaut list
            List<string> astronaut = new List<string>() {
                "ISS", "Sergey Prokopyev", "176"
            };

            // Ask the user to input the astronaut's country of origin
            Console.WriteLine("Enter the astronaut's country of origin:");
            string country = Console.ReadLine();

            // Add the country to the end of the list
            astronaut.Add(country);

            // Output the astronaut's details
            DisplayAstronautDetails(astronaut);
        }

        // Display the values from the given astronaut list
        public static void DisplayAstronautDetails(List<string> astronaut) {
            Console.WriteLine("\nAstronaut details:");

            // Repeat for each value in the list
            foreach (string value in astronaut) {
                Console.WriteLine(value);
            }
        }
    }
}