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

import java.util.Scanner;

class Selection
{
    // The main method is the entry point for all Java programs
    public static void main(String[] args)
    {
        showError();
    }


    // Example of a switch/case statement to match the error code
    public static void showError()
    {
        // Use Scanner for reading user input from the console
        Scanner scanner = new Scanner(System.in);

        System.out.println("Enter the error code: ");
        String errorCode = scanner.nextLine();

        switch (errorCode) {
            case "400":
                System.out.println("Bad request");
                break;
            case "401":
                System.out.println("Unauthorised request");
                break;
            case "403":
                System.out.println("Forbidden request");
                break;
            case "404":
                System.out.println("Page not found");
                break;
            case "408":
                System.out.println("Timeout error");
                break;
            default:
                System.out.println("Unknown error");
                break;
        }
    }


}