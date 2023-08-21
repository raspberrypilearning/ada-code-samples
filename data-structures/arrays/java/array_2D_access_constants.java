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
    // Index values of each level
    public static final int LEVEL_1 = 0;
    public static final int LEVEL_2 = 1;
    public static final int LEVEL_3 = 2;

    // The main method is the entry point for all Java programs
    public static void main(String[] args) {
        // Declare and initialise the two-dimensional array of words
        String[][] spellingWords = {
            { "me", "do", "it", "her", "him" },
            { "put", "ask", "says", "red", "any" },
            { "they", "where", "friend", "fast", "class" }
        };

        // Output the word for Level 3 at index 4
        int index = 4;
        String word = spellingWords[LEVEL_3][index];
        System.out.println("The word for Level 3 at index " + index + " is " + word);
    }
}