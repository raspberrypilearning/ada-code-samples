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
                    { "craft", "Tiangong" }, { "days", "112" } } },
                { "Deng Qingming", new Dictionary<string, string> {
                    { "craft", "Tiangong" }, { "days", "107" } } },
                { "Zhang Lu", new Dictionary<string, string> {
                    { "craft", "Tiangong" }, { "days", "107" } } },
                { "Stephen Bowen", new Dictionary<string, string> {
                    { "craft", "ISS" }, { "days", "54" } } },
                { "Warren Hoburg", new Dictionary<string, string> {
                    { "craft", "ISS" }, { "days", "14" } } },
                { "Sultan Al Neyadi", new Dictionary<string, string> {
                    { "craft", "ISS" }, { "days", "14" } } },
                { "Andrey Fedyaev", new Dictionary<string, string> {
                    { "craft", "ISS" }, { "days", "14" } } }
            };

            // Calculate the total number of days in space
            int total = CalculateTotalDays(astronautsByName);
            Console.WriteLine($"Total number of days in space: {total}");
        }

        // Calculate and return the sum of all the astronauts' days in space
        public static int CalculateTotalDays(
            Dictionary<string, Dictionary<string, string>> astronautsByName) {

            int totalDays = 0;

            // Repeat for each astronaut in the outer dictionary
            foreach (KeyValuePair<string, Dictionary<string, string>> kvp in astronautsByName) {
                string name = kvp.Key;
                Dictionary<string, string> astronaut = kvp.Value;
                totalDays += Convert.ToInt32(astronaut["days"]);
            }

            return totalDays;
        }
    }
}