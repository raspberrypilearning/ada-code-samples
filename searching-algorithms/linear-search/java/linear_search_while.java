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
        // Perform a linear search on the test data
        int[] testItems = new int[] {11, 25, 10, 29, 15, 13, 18};

        System.out.println("### Linear search version 2 (while loop) ###");
        System.out.println(Arrays.toString(testItems));

        // Search for a value and return the found index
        int itemToFind = 15;
        System.out.println("\nThe search item is " + itemToFind + "\n");
        int index = linearSearchVersion2(testItems, itemToFind);

        if (index == -1) {
            System.out.println("\n" + itemToFind + " was not found in the array");
        }
        else {
            System.out.println("\n" + itemToFind + " was found at index " + index);
        }
    }


    // A linear search algorithm that stops iterating if the item is found
    public static int linearSearchVersion2(int[] items, int searchItem) {
        // Initialise the variables
        int found_index = -1;
        int current = 0;
        boolean found = false;

        // Repeat while the end of the array has not been reached
        // and the search item has not been found
        while (found == false && current < items.length) {
            System.out.println("Checking index " + current + " with value " + items[current]);

            // Compare the item at the current index to the search item
            if (items[current] == searchItem) {
                // If the item has been found, store the current index 
                found_index = current;
                found = true; // Raise the flag to stop the loop
                System.out.println("Item found! Stopping the search");
            }
            current = current + 1; // Go to the next index in the array
        }
        // Return the index of the searchItem or -1 if not found
        return found_index;
    }


}