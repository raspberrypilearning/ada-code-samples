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
        // Index values of each year
        public const int Year1 = 0;
        public const int Year2 = 1;
        
        // Index values of each level
        public const int Level1 = 0;
        public const int Level2 = 1;
        public const int Level3 = 2;


        // The Main method is the entry point for all C# programs
        public static void Main() {
            // Declare and initialise the three-dimensional array of words
            string[,,] spellingWords = new string[2, 3, 5] { 
                { 
                    { "me", "do", "her", "it", "him" }, 
                    { "put", "ask", "says", "red", "any" }, 
                    { "they", "where", "friend", "fast", "class" }
                },
                { 
                    { "door", "find", "most", "bath", "eye" }, 
                    { "every", "great", "climb", "prove", "behind" }, 
                    { "clothes", "again", "improve", "should", "parents" } 
                } 
            };

            // Ask the user for the new word
            Console.WriteLine("Enter the new word:");
            string newWord = Console.ReadLine();

            // Update the last word for Year 1, Level 3
            int wordIndex = 4;
            spellingWords[Year1, Level3, wordIndex] = newWord;

            // Output the updated word
            string updatedWord = spellingWords[Year1, Level3, wordIndex];
            Console.WriteLine($"The word has been updated to {updatedWord}");
        }
    }
}