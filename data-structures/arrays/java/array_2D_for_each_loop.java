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

class Arrays2D  {
    // The main method is the entry point for all Java programs
    public static void main(String[] args) {
        // Declare and initialise the two-dimensional array of words
        String[][] spellingWords = {
            { "me", "do", "her", "it", "him" },
            { "put", "ask", "says", "red", "any" },
            { "they", "where", "friend", "fast", "class" }
        };

        // Output every word in the array
        System.out.println("Display every word in the spelling words array:");
        displayAllWords(spellingWords);
    }

    // Display the words of each level in the 2D array
    public static void displayAllWords(String[][] spellingWords) {

        // Repeat for each level
        for (String[] level : spellingWords) {
            // Output each word for the current year and level
            for (String word : level) {
                System.out.println(word);
            }
        }
    }
}