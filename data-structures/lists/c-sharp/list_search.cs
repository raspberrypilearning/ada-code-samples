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
    class SingleLists {
        // The Main method is the entry point for all C# programs
        public static void Main() {
            // Declare and initialise the astronaut list
            List<string> astronauts = new List<string>() {
                "Frank Rubio", "Stephen Bowen",  "Sultan Al Neyadi"
            };

            // Ask the user for an astronaut's name
            Console.WriteLine("Enter the name of an astronaut to find:");
            string nameToFind = Console.ReadLine();

            // Check if the name matches a value in the astronaut list
            bool found = CheckNameExists(astronauts, nameToFind);

            // Output the search results
            if (found) {
                Console.WriteLine("Astronaut found!");
            }
            else {
                Console.WriteLine("Astronaut not found in this data set");
            }
        }

        // Return true if the search value is found in the list
        public static bool CheckNameExists(List<string> astronauts, string searchName) {
            int i = 0;
            bool isFound = false;

            // Repeat while the search name has not been found
            while (!isFound && i < astronauts.Count) {
                // Check if the current name equals the search name
                if (astronauts[i].Equals(searchName)) {
                    isFound = true;
                }
                i += 1; // Increment the counter
            }

            return isFound;
        }
    }
}
