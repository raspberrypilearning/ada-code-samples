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

class Parameters
{
    // The main method is the entry point for all Java programs
    public static void main(String[] args) {
        // Use Scanner for reading user input from the console
        Scanner scanner = new Scanner(System.in);

        System.out.println("What is your name? ");
        String userName = scanner.nextLine();
        welcomeUser(userName);
    }


    // A welcome message that uses value from parameter
    public static void welcomeUser(String user) {
        System.out.println("Greetings " + user);
    }


}