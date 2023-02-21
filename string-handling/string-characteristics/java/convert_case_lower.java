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

class StringCharacteristics
{
    // The main method is the entry point for all Java programs
    public static void main(String[] args)
    {
        String letter = "B";
        char character = letter.charAt(0); // Extracts single character from string
        char lowerCase = convertToLower(character);
        System.out.println(lowerCase);
    }


    // Demonstrates how to use ASCII codes to convert letter case
    public static char convertToLower(char letter)
    {
        int letterCode = (int) letter;  // Gets denary ASCII code for letter
        int newLetterCode = letterCode + 32;
        char lowerCase = (char) newLetterCode;  // Convert new code to a character
        return lowerCase;
    }


}