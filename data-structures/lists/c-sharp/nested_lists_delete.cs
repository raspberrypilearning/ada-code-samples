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
    class NestedLists {
        // The Main method is the entry point for all C# programs
        public static void Main() {
            // Declare and initialise the nested list of astronauts
            List<List<string>> allAstronauts = new List<List<string>>() {
                new List<string>() { "ISS", "Sergey Prokopyev", "176" },
                new List<string>() { "ISS", "Dmitry Petelin", "176" },
                new List<string>() { "ISS", "Frank Rubio", "176" },
                new List<string>() { "Tiangong", "Fei Junlong", "112" },
                new List<string>() { "Tiangong", "Deng Qingming", "107" },
                new List<string>() { "Tiangong", "Zhang Lu", "107" },
                new List<string>() { "ISS", "Stephen Bowen", "54" },
                new List<string>() { "ISS", "Warren Hoburg", "14" },
                new List<string>() { "ISS", "Sultan Al Neyadi", "14" },
                new List<string>() { "ISS", "Andrey Fedyaev", "14" }
            };

            // Output the details of each astronaut in the list
            Console.WriteLine("\nDetails of each astronaut in the list:");
            DisplayAllAstronauts(allAstronauts);

            // Delete the astronaut stored at index 0
            int position = 0;
            Console.WriteLine($"\nDelete the astronaut at position {position}");
            DeleteAstronaut(allAstronauts, position);

            // Output the details of each astronaut in the list
            Console.WriteLine("\nDetails of each astronaut in the list:");
            DisplayAllAstronauts(allAstronauts);
        }

        // Delete an astronaut list at the given index
        public static void DeleteAstronaut(List<List<string>> allAstronauts,
            int astronautIndex) {

            allAstronauts.RemoveAt(astronautIndex);
        }

        // Display the values of each astronaut in the given list
        public static void DisplayAllAstronauts(List<List<string>> allAstronauts) {
            // Repeat for each astronaut in the outer list
            foreach (List<string> astronaut in allAstronauts) {
                // Repeat for each value in the inner list
                foreach (string value in astronaut) {
                    Console.Write($"{value}  "); // Do not print new line
                }
                Console.WriteLine(); // Print a new line after each astronaut
            }
        }
    }
}