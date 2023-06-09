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
    class NestedDictionaries {
        // The Main method is the entry point for all C# programs
        public static void Main() {
            // Declare and initialise the nested dictionary of astronauts
            var astronautsByName = new Dictionary<string, Dictionary<string, string>>() {
                { "Sergey Prokopyev", new Dictionary<string, string> {
                    { "craft", "ISS" }, { "days", "176" } } },
                { "Dmitry Petelin", new Dictionary<string, string> {
                    { "craft", "ISS" }, { "days", "176" } } },
                { "Frank Rubio", new Dictionary<string, string> {
                    { "craft", "ISS" }, { "days", "176" } } },
                { "Fei Junlong", new Dictionary<string, string> {
                    { "craft", "Shenzhou 15" }, { "days", "112" } } },
                { "Deng Qingming", new Dictionary<string, string> {
                    { "craft", "Shenzhou 15" }, { "days", "107" } } },
                { "Zhang Lu", new Dictionary<string, string> {
                    { "craft", "Shenzhou 15" }, { "days", "107" } } },
                { "Stephen Bowen", new Dictionary<string, string> {
                    { "craft", "ISS" }, { "days", "54" } } },
                { "Warren Hoburg", new Dictionary<string, string> {
                    { "craft", "ISS" }, { "days", "14" } } },
                { "Sultan Al Neyadi", new Dictionary<string, string> {
                    { "craft", "ISS" }, { "days", "14" } } },
                { "Andrey Fedyaev", new Dictionary<string, string> {
                    { "craft", "ISS" }, { "days", "14" } } }
            };

            // Ask the user to input the new astronaut's details
            Console.WriteLine("Enter the astronaut's full name:");
            string name = Console.ReadLine();
            Console.WriteLine("Enter the name of the spacecraft:");
            string spacecraft = Console.ReadLine();
            Console.WriteLine("Enter the current number of days in space:");
            string days = Console.ReadLine();

            // Add the new astronaut to the list
            AddNewAstronaut(astronautsByName, name, spacecraft, days);

            // Output the details of the new astronaut
            Console.WriteLine($"\nAstronaut name: {name}");
            var astronaut = astronautsByName[name];
            DisplayKeyValuePairs(astronaut);
        }

        // Add a new astronaut dictionary to the nested dictionary
        public static void AddNewAstronaut(
            Dictionary<string, Dictionary<string, string>> astronautsByName,
            string givenName, string givenSpacecraft, string givenDays) {

            // Create a new dictionary for the astronaut
            var newAstronaut = new Dictionary<string, string>() {
                { "craft", givenSpacecraft },
                { "days", givenDays }
            };

            // Add the new astronaut dictionary to the nested dictionary
            astronautsByName[givenName] = newAstronaut;
        }

        // Display the key-value pairs from the given astronaut dictionary
        public static void DisplayKeyValuePairs(Dictionary<string, string> astronaut) {
            Console.WriteLine("Astronaut dictionary:");

            // Repeat for each key-value pair in the dictionary
            foreach (KeyValuePair<string, string> kvp in astronaut) {
                string key = kvp.Key;
                string value = kvp.Value;
                Console.WriteLine($"Key: {key}, value: {value}");
            }
        }
    }
}