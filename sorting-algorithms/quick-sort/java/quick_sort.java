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

class SortingAlgorithms
{
    // The main method is the entry point for all Java programs
    public static void main(String[] args)
    {
        // Perform a quick sort on the test data
        //int[] testItems = new int[] {80, 64, 50, 43, 35, 21, 7, 3, 2}; // Least sorted
        //int[] testItems = new int[] {2, 3, 7, 35, 43, 21, 50, 64, 80}; // Nearly sorted
        //int[] testItems = new int[] {2, 3, 7, 21, 35, 43, 50, 64, 80}; // Sorted
        int[] testItems = new int[] {43, 21, 2, 50, 3, 80, 35, 7, 64}; // Random

        System.out.println("### Quick sort (recursive) ###");
        System.out.print("\nOriginal items ");
        System.out.println(Arrays.toString(testItems));
        System.out.println();

        // Assign the returned sorted array
        int[] sortedItems = quickSort(testItems, 0, testItems.length - 1);

        System.out.print("Sorted items ");
        System.out.println(Arrays.toString(sortedItems));
    }


    // A recursive quick sort algorithm
    public static int[] quickSort(int[] items, int start, int end)
    {
        // Base case for recursion:
        // The recursion will stop when the partition contains a single item
        if (start >= end) {
            return new int[0];
        }
        // Otherwise recursively call the function
        else {
            int pivotValue = items[start]; // Set to first item in the partition
            int lowMark = start + 1; // Set to second position in the partition
            int highMark = end; // Set to last position in the partition
            int temp;
            boolean finished = false;

            System.out.print(Arrays.toString(items)); // Testing
            System.out.println(" Pivot value: " + pivotValue + " Low mark: " + lowMark + " High mark: " + highMark);

            // Repeat until low and high values have been swapped as needed
            while (finished == false) {
                // Move the left pivot
                while (lowMark <= highMark && items[lowMark] <= pivotValue) {
                    lowMark = lowMark + 1; // Increment lowMark
                }

                // Move the right pivot
                while (items[highMark] >= pivotValue && highMark >= lowMark) {
                    highMark = highMark - 1; // Decrement highMark
                }

                // Check that the low mark doesn't overlap with the high mark
                if (lowMark < highMark) {
                    // Swap the values at lowMark and highMark
                    temp = items[lowMark];
                    items[lowMark] = items[highMark];
                    items[highMark] = temp;

                    System.out.print(Arrays.toString(items)); // Testing
                    System.out.println(" Swapped the values " + items[highMark] + " and " + items[lowMark]);
                }

                // Otherwise end the loop
                else {
                    finished = true;
                }
            }

            // Swap the pivot value and the value at highMark
            temp = items[start];
            items[start] = items[highMark];
            items[highMark] = temp;

            System.out.print(Arrays.toString(items)); // Testing
            System.out.println(" Swapped the pivot value " + pivotValue + " and " + items[start] + "\n");

            // Recursive call on the left partition
            quickSort(items, start, highMark - 1);

            // Recursive call on the right partition
            quickSort(items, highMark + 1, end);

            return items;
        }
    }


}