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

class TwoDimensionalArrays
{
    public static final int LEVEL1 = 0;
    public static final int LEVEL2 = 1;
    public static final int LEVEL3 = 2;

    // The main method is the entry point for all Java programs
    public static void main(String[] args) {
        String[][] spellingWords = new String[3][3]; // Declare a two-dimensional array

        spellingWords[0][0] = "school";
        spellingWords[0][1] = "pull";
        spellingWords[0][2] = "where";
        spellingWords[1][0] = "path";
        spellingWords[1][1] = "floor";
        spellingWords[1][2] = "sugar";
        spellingWords[2][0] = "accident";
        spellingWords[2][1] = "answer";
        spellingWords[2][2] = "eight";

        // Display all of the level 2 words
        for (int word = 0; word < spellingWords[LEVEL2].length; word++) {
            System.out.println(spellingWords[LEVEL2][word]);
        }
    }


}