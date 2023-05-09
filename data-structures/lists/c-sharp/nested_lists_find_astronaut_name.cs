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
        // Index values of each astronaut
        public const int CraftIndex = 0;
        public const int NameIndex = 1;
        public const int DaysIndex = 2;

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

            // Check if one of the astronaut lists contains a name substring
            Console.WriteLine("Enter the name of an astronaut to find:");
            string nameToFind = Console.ReadLine();
            int position = FindPositionOfAstronaut(allAstronauts, nameToFind);

            // Output the search results
            if (position == -1) {
                Console.WriteLine("Astronaut not found in this data set");
            }
            else {
                Console.WriteLine($"Astronaut found at position {position}");
                DisplayAstronautDetails(allAstronauts[position]);
            }
        }

        // Return the index of the astronaut that contains the search name
        public static int FindPositionOfAstronaut(List<List<string>> allAstronauts,
            string searchName) {

            int i = 0;
            int foundIndex = -1;  // Return -1 if no astronaut found

            // Repeat while the astronaut has not been found
            while (foundIndex == -1 && i < allAstronauts.Count) {
                // Check if the name value contains the search name substring
                if (allAstronauts[i][NameIndex].Contains(searchName)) {
                    // Stop searching and return the index
                    foundIndex = i;
                }
                i += 1; // Increment the counter
            }
       
            return foundIndex;
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