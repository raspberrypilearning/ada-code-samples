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

            // Ask the user to input the new astronaut's details
            Console.WriteLine("Enter the spacecraft's name:");
            string spacecraft = Console.ReadLine();

            Console.WriteLine("Enter the astronaut's full name:");
            string name = Console.ReadLine();

            Console.WriteLine("Enter the current number of days in space:");
            string days = Console.ReadLine();

            // Add the new astronaut to the list
            AddNewAstronaut(allAstronauts, spacecraft, name, days);

            // Output the details of the new astronaut
            int lastIndex = allAstronauts.Count - 1;
            List<string> astronaut = allAstronauts[lastIndex];
            DisplayAstronautDetails(astronaut);
        }

        // Add a new astronaut list to the end of the nested list
        public static void AddNewAstronaut(List<List<string>> allAstronauts,
            string givenSpacecraft, string givenName, string givenDays) {

            // Create a new list for the astronaut
            List<string> newAstronaut = new List<string>() {
                givenSpacecraft, givenName, givenDays
            };

            // Add the new astronaut list to the end of the nested list
            allAstronauts.Add(newAstronaut);
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