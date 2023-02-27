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

namespace AdaCodeSamples
{
    class Iteration
    {
        // The Main method is the entry point for all C# programs
        public static void Main()
        {
            int[] numbersToGuess = { 1, 4, 8, 3, 10 };
            
            Console.WriteLine("Guess my numbers, each number is between 1 and 10");

            // Repeat for each number in the array
            foreach (int number in numbersToGuess) {
                Console.WriteLine("Enter a number to guess: ");
                string userInput = Console.ReadLine();
                int guess = Int32.Parse(userInput);

                // Repeat while the user has not guessed the correct number
                while (guess != number) {
                    Console.WriteLine("Incorrect number. Try again: ");
                    userInput = Console.ReadLine();
                    guess = Int32.Parse(userInput);
                }

                Console.WriteLine("Well done, next number to guess");
            }
        }
        

    }
}
