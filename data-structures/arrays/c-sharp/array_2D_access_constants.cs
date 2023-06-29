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
    class Arrays2D {
        // Index values of each level
        public const int Level1 = 0;
        public const int Level2 = 1;
        public const int Level3 = 2;


        // The Main method is the entry point for all C# programs
        public static void Main() {
            // Declare and initialise the two-dimensional array of words
            string[,] spellingWords = new string[3, 5] { 
                { "me", "do", "her", "it", "him" }, 
                { "put", "ask", "says", "red", "any" }, 
                { "they", "where", "friend", "fast", "class" }
            };

            // Output the word for Level 3 at index 4
            int index = 4;
            string word = spellingWords[Level3, index];
            Console.WriteLine($"The word for Level 3 at index {index} is {word}");
        }
    }
}