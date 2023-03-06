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
        // Compare a bubble sort with an insertion sort algorithm
        System.out.println("\n### Bubble sort (while and for loops improved) ###");
        bubbleSort(getTestData());

        System.out.println("\n### Insertion sort ###");
        insertionSort(getTestData());
    }


    // Returns the test data for the algorithm
    public static int[] getTestData() {
        //int[] testItems = new int[] {80, 64, 50, 43, 35, 21, 7, 3, 2}; // Least sorted
        //int[] testItems = new int[] {2, 3, 7, 35, 43, 21, 50, 64, 80}; // Nearly sorted
        //int[] testItems = new int[] {2, 3, 7, 21, 35, 43, 50, 64, 80}; // Sorted
        int[] testItems = new int[] {43, 21, 2, 50, 3, 80, 35, 7, 64}; // Random

        System.out.print("Data: ");
        System.out.println(Arrays.toString(testItems));

        return testItems;
    }


    // A bubble sort algorithm (while and for loops improved)
    public static void bubbleSort(int[] items) {
        // Initialise the variables
        int numItems = items.length;
        boolean swapped = true;
        int passNum = 1;
        int totalComparisons = 0; // Testing

        // Repeat while one or more swaps have been made
        while (swapped == true) {
            swapped = false;
            int index = 0; // Declared outside of the for loop for testing below
            // Perform a pass, reducing the number of comparisons each time
            for (index = 0; index < numItems - passNum; index++) {
                // Compare items to check if they are out of order
                if (items[index] > items[index + 1]) {
                    // Swap the items
                    int temp = items[index];
                    items[index] = items[index + 1];
                    items[index + 1] = temp;
                    swapped = true;
                }
                totalComparisons = totalComparisons + 1; // Testing
            }

            // Testing
            System.out.print("Pass " + passNum + ": ");
            System.out.print(Arrays.toString(items));
            System.out.println("  Comparisons: " + index);

            passNum = passNum + 1;
        }
        System.out.println("Total comparisons: " + totalComparisons); // Testing
    }


    // An insertion sort algorithm
    public static void insertionSort(int[] items) {
        // Initialise the variables
        int numItems = items.length;
        int totalComparisons = 0; // Testing

        // Repeat for each item in the list, starting at the second item
        for (int index = 1; index < numItems; index++) {
            // Get the value of the next item to insert
            int itemToInsert = items[index];

            // Get the current position of the last sorted item
            int position = index - 1;

            // Testing
            int comparisons = 1;
            totalComparisons = totalComparisons + 1;

            // Repeat while there are still items in the array to check
            // and the current sorted item is greater than the item to insert
            while (position >= 0 && items[position] > itemToInsert) {
                // Copy the value of the sorted item up one place
                items[position + 1] = items[position];

                // Get the position of the next sorted item
                position = position - 1;

                // Testing
                comparisons = comparisons + 1;
                totalComparisons = totalComparisons + 1; // Testing
            }

            // Copy the value of the item to insert into the correct position
            items[position + 1] = itemToInsert;

            // Testing
            System.out.print("Pass " + index + ": ");
            System.out.print(Arrays.toString(items));
            System.out.println("  Comparisons: " + comparisons);
        }
        System.out.println("Total comparisons: " + totalComparisons); // Testing
    }


}