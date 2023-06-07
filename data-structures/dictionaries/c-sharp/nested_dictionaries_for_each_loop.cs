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

            // Output the details of each astronaut in the dictionary
            Console.WriteLine("Details of each astronaut:");
            DisplayAllAstronauts(astronautsByName);
        }

        // Display the key-value pairs of each astronaut in the nested dictionary
        public static void DisplayAllAstronauts(
            Dictionary<string, Dictionary<string, string>> astronautsByName) {

            // Repeat for each astronaut in the outer dictionary
            foreach (KeyValuePair<string, Dictionary<string, string>> kvp in astronautsByName) {
                string name = kvp.Key;
                Dictionary<string, string> astronaut = kvp.Value;
                Console.WriteLine(name);

                // Repeat for each key-value pair in the inner dictionary
                foreach (KeyValuePair<string, string> innerKvp in astronaut) {
                    string key = innerKvp.Key;
                    string value = innerKvp.Value;
                    Console.WriteLine($"Key: {key}, value: {value}");
                }
                Console.WriteLine(); // Print an extra line after each astronaut
            }
        }
    }
}