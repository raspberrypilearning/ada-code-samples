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

            // Find all the astronauts on a spacecraft
            Console.WriteLine("Get a list of all astronauts that are on a specific spacecraft");
            Console.WriteLine("Enter the spacecraft name:");
            string spacecraft = Console.ReadLine();
            List<List<string>> foundAstronauts = GetAstronautsBySpacecraft(allAstronauts, spacecraft);

            // Output the search results
            if (foundAstronauts.Count == 0) {
               Console.WriteLine($"\nNo astronauts found in the spacecraft {spacecraft}");
            }
            else {
               Console.WriteLine("\nAstronauts found:");
               DisplayAllAstronauts(foundAstronauts);
            }
        }
        

        // Return a list of astronauts that are on a given spacecraft
        public static List<List<string>> GetAstronautsBySpacecraft(
            List<List<string>> allAstronauts, string givenSpacecraft) {

            // Declare a list to store the found astronauts in
            List<List<string>> foundList = new List<List<string>>();

            // Repeat for all astronauts in the outer list using the index i
            for (int i = 0; i < allAstronauts.Count; i++) {
                // Check if the astronaut is in the spacecraft
                if (givenSpacecraft.Equals(allAstronauts[i][CraftIndex])) {
                    foundList.Add(allAstronauts[i]);
                }
            }

            return foundList;
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