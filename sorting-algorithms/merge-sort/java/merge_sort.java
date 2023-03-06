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
    public static void main(String[] args) {
        // Perform a merge sort on the test data
        //int[] testItems = new int[] {80, 64, 50, 43, 35, 21, 7, 3, 2}; // Least sorted
        //int[] testItems = new int[] {2, 3, 7, 35, 43, 21, 50, 64, 80}; // Nearly sorted
        //int[] testItems = new int[] {2, 3, 7, 21, 35, 43, 50, 64, 80}; // Sorted
        int[] testItems = new int[] { 43, 21, 2, 50, 3, 80, 35, 7, 64 }; // Random

        System.out.println("### Merge sort (recursive) ###");
        System.out.print("Original items ");
        System.out.println(Arrays.toString(testItems));

        int[] sortedItems = mergeSort(testItems); // Assign the returned sorted array

        System.out.print("Sorted items ");
        System.out.println(Arrays.toString(sortedItems));
    }


    // A recursive merge sort algorithm
    public static int[] mergeSort(int[] items) {
        int[] leftHalf; // Stores items in the left half of the items array
        int[] rightHalf; // Stores items in the right half of the items array
        int[] mergedItems = new int[items.length]; // Stores the merged items in each recursive call

        // Base case for recursion:
        // The recursion will stop when the array has been divided into single items
        if (items.length <= 1) {
            return items;
        }
        else {
            System.out.print("Splitting ");
            System.out.println(Arrays.toString(items));

            int midpoint = (items.length - 1) / 2; // Calculate the midpoint index
            int leftSize = midpoint + 1; // Size of the left half array
            int rightSize; // Size of the right half array

            // Check if the total number of items is even
            if (items.length % 2 == 0) {
                rightSize = midpoint + 1; // Left and right arrays are equal in size
            }
            else {
                rightSize = midpoint; // Right array will have one less item than left array
            }

            leftHalf = new int[leftSize]; // Create left half array
            rightHalf = new int[rightSize]; // Create right half array

            // Populate left half array with the items up to and including the midpoint
            for (int i = 0; i < leftSize; i++) {
                leftHalf[i] = items[i];
            }

            // Populate right half array with the items after the midpoint
            int indexItems = midpoint + 1;
            for (int i = 0; i < rightSize; i++) {
                rightHalf[i] = items[indexItems];
                indexItems++;
            }

            leftHalf = mergeSort(leftHalf); // Recursive call on left half
            rightHalf = mergeSort(rightHalf); // Recursive call on right half

            System.out.println("Merging: "); // Testing
            System.out.println(Arrays.toString(leftHalf) + " and " + Arrays.toString(rightHalf));

            mergedItems = merge(leftHalf, rightHalf); // Call function to merge both halves

            System.out.println("Merged items:"); // Testing
            System.out.println(Arrays.toString(mergedItems));
            System.out.println();

            return mergedItems;
        }
    }

    // Merges the items in left and right into a new ordered list called merged
    public static int[] merge(int[] left, int[] right) {
        int mergedSize = left.length + right.length; // Size of the new array
        int[] merged = new int[mergedSize]; // New array for merging the items

        int indexLeft = 0; // left current position
        int indexRight = 0; // right current position
        int indexMerged = 0; // merged current position

        // While there are still items to merge
        while (indexLeft < left.length && indexRight < right.length) {
            // Find the lowest of the two items being compared and add it to the new array
            if (left[indexLeft] < right[indexRight]) {
                merged[indexMerged] = left[indexLeft];
                indexLeft++;
                indexMerged++;
            }
            else {
                merged[indexMerged] = right[indexRight];
                indexRight++;
                indexMerged++;
            }
        }

        // Add to the merged array any remaining data from left array
        while (indexLeft < left.length) {
            merged[indexMerged] = left[indexLeft];
            indexLeft++;
            indexMerged++;
        }

        // Add to the merged array any remaining data from right array
        while (indexRight < right.length) {
            merged[indexMerged] = right[indexRight];
            indexRight++;
            indexMerged++;
        }

        return merged;
    }


}