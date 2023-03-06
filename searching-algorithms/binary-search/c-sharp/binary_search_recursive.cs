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
            // Perform a binary search on the test data
            int[] testItems = new int[] {10, 11, 13, 15, 18, 25, 29};

            int firstIndex = 0;
            int lastIndex = testItems.Length - 1;

            Console.WriteLine("### Binary search (recursive) ###");
            Console.WriteLine("[{0}]", string.Join(", ", testItems));

            // Search for a value and return the found index
            int itemToFind = 18;
            Console.WriteLine("\nThe search item is " + itemToFind + "\n");
            int index = BinarySearchRecursive(testItems, itemToFind, firstIndex, lastIndex);

            if (index == -1) {
                Console.WriteLine($"\n{itemToFind} was not found in the array");
            }
            else {
                Console.WriteLine($"\n{itemToFind} was found at index {index}");
            }
        }
        

        // Performs a binary search recursively
        public static int BinarySearchRecursive(int[] items, int searchItem, int first, int last) {
            // Base case for recursion: The recursion will stop when the
            // index of the first item is greater than the index of last
            if (first > last) {
                return -1; // Return -1 if the search item is not found
            }
            // Recursively call the function
            else {
                // Find the midpoint position (in the middle of the range)
                int midpoint = (first + last) / 2;
                Console.WriteLine($"Checking from index {first} to {last} with midpoint {midpoint}");

                // Compare the item at the midpoint to the search item
                if (items[midpoint] == searchItem) {
                    // If the item has been found, return the midpoint position
                    Console.WriteLine("Item found! Stopping the search");
                    return midpoint;
                }
                // Check if the search item is greater than the item at the midpoint is less than the 
                else if (searchItem > items[midpoint]) {
                    // Focus on the items after the midpoint
                    first = midpoint + 1;
                    return BinarySearchRecursive(items, searchItem, first, last);
                }
                // Otherwise the item at the midpoint is greater than the search item
                else {
                    // Focus on the items before the midpoint
                    last = midpoint - 1;
                    return BinarySearchRecursive(items, searchItem, first, last);

                }
            }
        }
        

    }
}