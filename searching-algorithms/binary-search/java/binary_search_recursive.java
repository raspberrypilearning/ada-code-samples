/*
Raspberry Pi Foundation
Developed as part of Ada Computer Science

Usage licensed under CC BY-NC-SA 4.0

Note: This file is designed to be copied out and compiled on your machine.
In order for the program to compile properly in some IDEs, you need to ensure that the
class filename is the same as the class name with the main method in it.

To run this file you need to:
1. Copy the contents
2. Create a Java project in the IDE of your choice (Eclipse, for example)
3. Create a new Java Class that uses the same name as the class containing the main method in this program
4. Paste the contents into the new Java Class
5. Save and run the program
*/

import java.util.Arrays;

class SearchingAlgorithms
{
    // The main method is the entry point for all Java programs
    public static void main(String[] args) {
        // Perform a binary search on the test data
        int[] testItems = new int[] {10, 11, 13, 15, 18, 25, 29};

        int firstIndex = 0;
        int lastIndex = testItems.length - 1;

        System.out.println("### Binary search (recursive) ###");
        System.out.println(Arrays.toString(testItems));

        // Search for a value and return the found index
        int itemToFind = 18;
        System.out.println("\nThe search item is " + itemToFind + "\n");
        int index = binarySearchRecursive(testItems, itemToFind, firstIndex, lastIndex);

        if (index == -1) {
            System.out.println("\n" + itemToFind + " was not found in the array");
        }
        else {
            System.out.println("\n" + itemToFind + " was found at index " + index);
        }
    }


    // Performs a binary search recursively
    public static int binarySearchRecursive(int[] items, int searchItem, int first, int last) {
        // Base case for recursion: The recursion will stop when the
        // index of the first item is greater than the index of last
        if (first > last) {
            return -1; // Return -1 if the search item is not found
        }
        // Recursively call the function
        else {
            // Find the midpoint position (in the middle of the range)
            int midpoint = (first + last) / 2;
            System.out.println("Checking from index " + first + " to " + last + " with midpoint " + midpoint);

            // Compare the item at the midpoint to the search item
            if (items[midpoint] == searchItem) {
                // If the item has been found, return the midpoint position
                System.out.println("Item found! Stopping the search");
                return midpoint;
            }
            // Check if the search item is greater than the item at the midpoint is less than the 
            else if (searchItem > items[midpoint]) {
                // Focus on the items after the midpoint
                first = midpoint + 1;
                return binarySearchRecursive(items, searchItem, first, last);
            }
            // Otherwise the item at the midpoint is greater than the search item
            else {
                // Focus on the items before the midpoint
                last = midpoint - 1;
                return binarySearchRecursive(items, searchItem, first, last);

            }
        }
    }


}