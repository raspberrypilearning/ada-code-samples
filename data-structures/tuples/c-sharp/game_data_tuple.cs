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

namespace AdaCodeSamples {
    class Tuples {
        // The Main method is the entry point for all C# programs
        public static void Main() {
            Console.WriteLine("### Tuple ###");

            // Use a tuple of 3 elements to store data about a game:
            // playerName, level, time
            Tuple<string, int, float> gameData = LoadGameData();

            // Output the values of the tuple
            Console.WriteLine($"\nPlayer: {gameData.Item1}");
            Console.WriteLine($"Level: {gameData.Item2}");
            Console.WriteLine($"Time played (seconds): {gameData.Item3}");
        }


        // Demonstrates returning a tuple of multiple data types
        public static Tuple<string, int, float> LoadGameData() {
            string playerName = "TopGamer99";
            int level = 5;
            float time = 764.312f;

            // Create and return a tuple containing 3 elements
            return Tuple.Create(playerName, level, time);
        }


    }
 }