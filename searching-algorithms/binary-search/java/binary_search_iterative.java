/*
Raspberry Pi Foundation
Developed to be used alongside Isaac Computer Science,
part of the National Centre for Computing Education
Usage licensed under CC BY-SA 4

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
    public static void main(String[] args)
    {
        // Perform a binary search on the test data
        int[] testItems = new int[] {10, 11, 13, 15, 18, 25, 29};

        System.out.println("### Binary search (iterative) ###");
        System.out.println(Arrays.toString(testItems));

        // Search for a value and return the found index
        int itemToFind = 18;
        System.out.println("\nThe search item is " + itemToFind + "\n");
        int index = binarySearch(testItems, itemToFind);

        if (index == -1) {
            System.out.println("\n" + itemToFind + " was not found in the array");
        }
        else {
            System.out.println("\n" + itemToFind + " was found at index " + index);
        }
    }


    // An iterative binary search algorithm
    public static int binarySearch(int[] items, int searchItem)
    {
        // Initialise the variables
        boolean found = false;
        int foundIndex = -1;
        int first = 0;
        int last = items.length - 1;
        int midpoint = 0;

        // Repeat while there are still items between first and last 
        // and the search item has not been found
        while (first <= last && found == false) {
            // Find the midpoint position (in the middle of the range)
            midpoint = (first + last) / 2;
            System.out.println("Checking from index " + first + " to " + last + " with midpoint " + midpoint);

            // Compare the item at the midpoint to the search item
            if (items[midpoint] == searchItem) {
                // If the item has been found, store the midpoint position
                foundIndex = midpoint;
                found = true; // Raise the flag to stop the loop
                System.out.println("Item found! Stopping the search");
            }
            // Check if the item at the midpoint is less than the search item
            else if (items[midpoint] < searchItem) {
                // Focus on the items after the midpoint
                first = midpoint + 1;
            }
            // Otherwise the item at the midpoint is greater than the search item
            else {
                // Focus on the items before the midpoint
                last = midpoint - 1;
            }
        }
        // Return the position of the searchItem or -1 if not found
        return foundIndex;
    }


}