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

import java.util.ArrayList;
import java.util.Scanner;

class SimpleLists {
    // The main method is the entry point for all Java programs
    public static void main(String[] args) {
        // Declare and initialise the astronaut list
        ArrayList<String> astronaut = new ArrayList<String>();
        astronaut.add("ISS");
        astronaut.add("Sergey Prokopyev");
        astronaut.add("176");

        // Use Scanner for reading user input from the console
        Scanner scanner = new Scanner(System.in);

        // Ask the user to input the astronaut's country of origin
        System.out.println("Enter the astronaut's country of origin:");
        String country = scanner.nextLine();

        // Add the country to the end of the list
        astronaut.add(country);

        // Output the astronaut's details
        displayAstronautDetails(astronaut);
    }

    // Display the values from the given astronaut list
    public static void displayAstronautDetails(ArrayList<String> astronaut) {
        System.out.println("\nAstronaut details:");

        // Repeat for each value in the list
        for (String value : astronaut) {
            System.out.println(value);
        }
    }
}