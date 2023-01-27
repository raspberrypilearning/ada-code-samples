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

class SortingAlgorithms
{
    // The main method is the entry point for all Java programs
    public static void main(String[] args)
    {
        // Perform a bubble sort on the test data
        //int[] testItems = new int[] {80, 64, 50, 43, 35, 21, 7, 3, 2}; // Least sorted
        //int[] testItems = new int[] {2, 3, 7, 35, 43, 21, 50, 64, 80}; // Nearly sorted
        //int[] testItems = new int[] {2, 3, 7, 21, 35, 43, 50, 64, 80}; // Sorted
        int[] testItems = new int[] {43, 21, 2, 50, 3, 80, 35, 7, 64}; // Random

        System.out.println("### Bubble sort version 3 (while and for loops improved) ###");
        System.out.println(Arrays.toString(testItems));

        bubbleSortVersion3(testItems);
    }


    // A more efficient bubble sort that reduces the number of comparisons per pass
    public static void bubbleSortVersion3(int[] items)
    {
        // Initialise the variables
        int numItems = items.length;
        boolean swapped = true;
        int passNum = 1;

        // Repeat while one or more swaps have been made
        while (swapped == true) {
            swapped = false;
            // Perform a pass, reducing the number of comparisons each time
            for (int index = 0; index < numItems - passNum; index++) {
                // Compare items to check if they are out of order
                if (items[index] > items[index + 1]) {
                    // Swap the items
                    int temp = items[index];
                    items[index] = items[index + 1];
                    items[index + 1] = temp;
                    swapped = true;
                }
            }
            passNum = passNum + 1;
            System.out.println(Arrays.toString(items)); // Testing
        }
    }


}