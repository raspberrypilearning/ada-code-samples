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
    class SearchingAlgorithms {
        // The Main method is the entry point for all C# programs
        public static void Main() {
            // Perform a linear search on the test data
            int[] testItems = new int[] {11, 25, 10, 29, 15, 13, 18};

            Console.WriteLine("### Linear search version 1 (for loop) ###");
            Console.WriteLine("[{0}]", string.Join(", ", testItems));

            // Search for a value and return the found index
            int itemToFind = 15;
            Console.WriteLine("\nThe search item is " + itemToFind + "\n");
            int index = LinearSearchVersion1(testItems, itemToFind);

            if (index == -1) {
                Console.WriteLine($"\n{itemToFind} was not found in the array");
            }
            else {
                Console.WriteLine($"\n{itemToFind} was found at index {index}");
            }
        }


        // A linear search algorithm that iterates through every item in the array
        public static int LinearSearchVersion1(int[] items, int searchItem) {
            // Initialise the variable
            int found_index = -1;

            // Repeat until the end of the array is reached
            for (int current = 0; current < items.Length; current++) {
                Console.WriteLine($"Checking index {current} with value {items[current]}");

                // Compare the item at the current index to the search item
                if (items[current] == searchItem) {
                    // If the item has been found, store the current index 
                    found_index = current;
                    Console.WriteLine("Item found!");
                }
            }
            // Return the index of the search_item or -1 if not found
            return found_index;
        }
        

    }
}