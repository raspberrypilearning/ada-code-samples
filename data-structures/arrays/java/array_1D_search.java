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

import java.util.Scanner;

class Arrays1D  {
    // The main method is the entry point for all Java programs
    public static void main(String[] args) {
        // Declare and initialise the array of words
        String[] spellingWords = {
            "me", "do", "it", "her", "him"
        };

        // Use Scanner for reading user input from the console
        Scanner scanner = new Scanner(System.in);

        // Ask the user for a word to find
        System.out.println("Enter a word to find:");
        String wordToFind = scanner.nextLine();

        // Check if the word matches a value in the spelling array
        boolean found = checkWordExists(spellingWords, wordToFind);

        // Output the search results
        if (found) {
            System.out.println("Word found!");
        }
        else {
            System.out.println("Word not found in the array");
        }
    }

    // Return Boolean true if search word is found in the array
    public static boolean checkWordExists(String[] spellingWords, String searchWord) {
        int i = 0;
        boolean isFound = false;

        // Repeat while the search word has not been found
        while (!isFound && i < spellingWords.length) {
            // Check if the words match
            if (spellingWords[i].equals(searchWord)) {
                isFound = true;
            }
            i += 1; // Increment the counter
        }

        return isFound;
    }
}
