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

class StringValidation {
    // The main method is the entry point for all Java programs
    public static void main(String[] args) {
        // Use Scanner for reading user input from the console
        Scanner scanner = new Scanner(System.in);

        System.out.println("Enter a string to check if it is empty:");
        String userInput = scanner.nextLine();
        boolean isEmpty = checkEmptyString(userInput);

        if (isEmpty == true) {
            System.out.println("Yes, the string is empty!");
        }
        else {
            System.out.println("No, the string is not empty!");
        }
    }


    // Checks if a string is empty
    public static boolean checkEmptyString(String myString) {
        boolean empty = false;

        if (myString.isEmpty()) {
            empty = true;
        }

        return empty;
    }


}