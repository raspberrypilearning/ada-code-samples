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

class SortingAlgorithms {
    // The main method is the entry point for all Java programs
    public static void main(String[] args) {
        // Perform a bubble sort on the test data
        //int[] testItems = new int[] {80, 64, 50, 43, 35, 21, 7, 3, 2}; // Least sorted
        //int[] testItems = new int[] {2, 3, 7, 35, 43, 21, 50, 64, 80}; // Nearly sorted
        //int[] testItems = new int[] {2, 3, 7, 21, 35, 43, 50, 64, 80}; // Sorted
        int[] testItems = new int[] {43, 21, 2, 50, 3, 80, 35, 7, 64}; // Random

        System.out.println("### Bubble sort version 1 (for loops) ###");
        System.out.println(Arrays.toString(testItems));

        bubbleSortVersion1(testItems);
    }


    // An inefficient bubble sort that uses nested for loops
    public static void bubbleSortVersion1(int[] items) {
        // Initialise the variables
        int numItems = items.length;

        // Pass through the array of items n-1 times
        for (int passNum = 1; passNum < numItems; passNum++) {
            // Perform a pass
            for (int index = 0; index < numItems - 1; index++) {
                // Compare items to check if they are out of order
                if (items[index] > items[index + 1]) {
                    // Swap the items
                    int temp = items[index];
                    items[index] = items[index + 1];
                    items[index + 1] = temp;
                }
            }
            System.out.println(Arrays.toString(items)); // Testing
        }
    }


}