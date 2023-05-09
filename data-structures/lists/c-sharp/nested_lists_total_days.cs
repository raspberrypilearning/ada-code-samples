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

            // Calculate the total number of days in space
            int total = CalculateTotalDays(allAstronauts);
            Console.WriteLine($"Total number of days in space: {total}");
        }

        // Calculate and return the sum of all the astronauts' days in space
        public static int CalculateTotalDays(List<List<string>> allAstronauts) {
            int totalDays = 0;

            // Repeat for each astronaut in the outer list
            foreach (List<string> astronaut in allAstronauts) {
                // Add the number of days to the total
                totalDays += Int32.Parse(astronaut[DaysIndex]);
            }

            return totalDays;
        }
    }
}