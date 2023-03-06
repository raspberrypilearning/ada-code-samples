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

        System.out.println("### Linear search version 1 (for loop) ###");
        System.out.println(Arrays.toString(testItems));

        // Search for a value and return the found index
        int itemToFind = 15;
        System.out.println("\nThe search item is " + itemToFind + "\n");
        int index = linearSearchVersion1(testItems, itemToFind);

        if (index == -1) {
            System.out.println("\n" + itemToFind + " was not found in the array");
        }
        else {
            System.out.println("\n" + itemToFind + " was found at index " + index);
        }
    }


    // A linear search algorithm that iterates through every item in the array
    public static int linearSearchVersion1(int[] items, int searchItem) {
        // Initialise the variable
        int found_index = -1;

        // Repeat until the end of the array is reached
        for (int current = 0; current < items.length; current++) {
            System.out.println("Checking index " + current + " with value " + items[current]);

            // Compare the item at the current index to the search item
            if (items[current] == searchItem) {
                // If the item has been found, store the current index 
                found_index = current;
                System.out.println("Item found!");
            }
        }
        // Return the index of the search_item or -1 if not found
        return found_index;
    }


}