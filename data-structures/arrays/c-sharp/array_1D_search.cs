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
    class Arrays1D {
        // The Main method is the entry point for all C# programs
        public static void Main() {
            // Declare and initialise the array of words
            string[] spellingWords = new string[5] { 
                "me", "do", "it", "her", "him"
            };

            // Ask the user for a word to find
            Console.WriteLine("Enter a word to find:");
            string wordToFind = Console.ReadLine();

            // Check if the word matches a value in the spelling array
            bool found = CheckWordExists(spellingWords, wordToFind);

            // Output the search results
            if (found) {
                Console.WriteLine("Word found!");
            }
            else {
                Console.WriteLine("Word not found in the array");
            }
        }

        // Return Boolean true if search word is found in the array
        public static bool CheckWordExists(string[] spellingWords, string searchWord) {
            int i = 0;
            bool isFound = false;

            // Repeat while the search word has not been found
            while (!isFound && i < spellingWords.Length) {
                // Check if the words match
                if (spellingWords[i].Equals(searchWord)) {
                    isFound = true;
                }
                i += 1; // Increment the counter
            }

            return isFound;
        }
    }
}
