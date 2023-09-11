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
    class Arrays3D {
        // The Main method is the entry point for all C# programs
        public static void Main() {
            // Declare and initialise the three-dimensional array of words
            string[,,] spellingWords = new string[2, 3, 5] { 
                { 
                    { "me", "do", "it", "her", "him" }, 
                    { "put", "ask", "says", "red", "any" }, 
                    { "they", "where", "friend", "fast", "class" }
                },
                { 
                    { "door", "find", "most", "bath", "eye" }, 
                    { "every", "great", "climb", "prove", "behind" }, 
                    { "clothes", "again", "improve", "should", "parents" } 
                } 
            };

            // Output every word in the array
            Console.WriteLine("Display each word along with the year group and level:");
            DisplayAllWords(spellingWords);
        }

        // Display the words of each year and level in the 3D array
        public static void DisplayAllWords(string[,,] spellingWords) {

            // Repeat for each year
            int numYears = spellingWords.GetLength(0);
            for (int i = 0; i < numYears; i++) {
                int yearNum = i + 1;  // Year index starts from 0
                Console.WriteLine($"\n### Year {yearNum} ###");

                // Repeat for each level
                int numLevels = spellingWords.GetLength(1);
                for (int j = 0; j < numLevels; j++) {
                    int levelNum = j + 1;  // Level index starts from 0
                    Console.WriteLine($"\nLevel {levelNum}:");

                    // Output each word for the current year and level
                    int numWords = spellingWords.GetLength(2);
                    for (int k = 0; k < numWords; k++) {
                        Console.WriteLine(spellingWords[i, j, k]);
                    }
                }
            }
        }
    }
}