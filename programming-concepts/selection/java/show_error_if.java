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

class Selection {
    // The main method is the entry point for all Java programs
    public static void main(String[] args) {
        showError();
    }


    // Example of a switch/case statement to match the error code
    public static void showError() {
        // Use Scanner for reading user input from the console
        Scanner scanner = new Scanner(System.in);

        System.out.println("Enter the error code: ");
        String errorCode = scanner.nextLine();

        if ("400".equals(errorCode)) {
            System.out.println("Bad request");
        }
        else if ("401".equals(errorCode)) {
            System.out.println("Unauthorised request");
        }
        else if ("403".equals(errorCode)) {
            System.out.println("Forbidden request");
        }
        else if ("404".equals(errorCode)) {
            System.out.println("Page not found");
        }
        else if ("408".equals(errorCode)) {
            System.out.println("Timeout error");
        }
        else {
            System.out.println("Unknown error");
        }
    }


}