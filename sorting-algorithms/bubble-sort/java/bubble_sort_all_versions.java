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
        // Execute all three versions of the bubble sort algorithms
        System.out.println("\n### Bubble sort version 1 (for loops) ###");
        bubbleSortVersion1(getTestData());

        System.out.println("\n### Bubble sort version 2 (while and for loops) ###");
        bubbleSortVersion2(getTestData());

        System.out.println("\n### Bubble sort version 3 (while and for loops improved) ###");
        bubbleSortVersion3(getTestData());
    }


    // Returns the test data for the algorithm
    public static int[] getTestData()
    {
        //int[] testItems = new int[] {80, 64, 50, 43, 35, 21, 7, 3, 2}; // Least sorted
        //int[] testItems = new int[] {2, 3, 7, 35, 43, 21, 50, 64, 80}; // Nearly sorted
        //int[] testItems = new int[] {2, 3, 7, 21, 35, 43, 50, 64, 80}; // Sorted
        int[] testItems = new int[] {43, 21, 2, 50, 3, 80, 35, 7, 64}; // Random

        System.out.print("Data: ");
        System.out.println(Arrays.toString(testItems));

        return testItems;
    }


    // An inefficient bubble sort that uses nested for loops
    public static void bubbleSortVersion1(int[] items)
    {
        int numItems = items.length;
        int passNum; // Declared outside of the for loop for testing below

        for (passNum = 1; passNum < numItems; passNum++) {
            int index = 0; // Declared outside of the for loop for testing below
            for (index = 0; index < numItems - 1; index++) {
                if (items[index] > items[index + 1]) {
                    int temp = items[index];
                    items[index] = items[index + 1];
                    items[index + 1] = temp;
                }
            }
            // Testing
            int comparisons = index + 1;
            System.out.print("Pass " + passNum + ": ");
            System.out.print(Arrays.toString(items));
            System.out.println("  Comparisons: " + comparisons);
        }
    }


    // A quite efficient bubble sort that stops if the items are sorted
    public static void bubbleSortVersion2(int[] items)
    {
        int numItems = items.length;
        boolean swapped = true;
        int passNum = 1; // Testing

        while (swapped == true) {
            swapped = false; // Assume sorted
            int index = 0; // Declared outside of the for loop for testing below
            for (index = 0; index < numItems - 1; index++) {
                if (items[index] > items[index + 1]) {
                    int temp = items[index];
                    items[index] = items[index + 1];
                    items[index + 1] = temp;
                    swapped = true;
                }
            }
            // Testing
            int comparisons = index + 1;
            System.out.print("Pass " + passNum + ": ");
            System.out.print(Arrays.toString(items));
            System.out.println("  Comparisons: " + comparisons);

            passNum = passNum + 1;
        }
    }


    // A more efficient bubble sort that reduces the number of comparisons per pass
    public static void bubbleSortVersion3(int[] items)
    {
        int numItems = items.length;
        boolean swapped = true;
        int passNum = 1;

        while (swapped == true) {
            swapped = false; // Assume sorted
            int index = 0; // Declared outside of the for loop for testing below
            for (index = 0; index < numItems - passNum; index++) {
                if (items[index] > items[index + 1]) {
                    int temp = items[index];
                    items[index] = items[index + 1];
                    items[index + 1] = temp;
                    swapped = true;
                }
            }
            // Testing
            int comparisons = index + 1;
            System.out.print("Pass " + passNum + ": ");
            System.out.print(Arrays.toString(items));
            System.out.println("  Comparisons: " + comparisons);

            passNum = passNum + 1;
        }
    }


}