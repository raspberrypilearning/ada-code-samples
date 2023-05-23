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

class SingleLists {
    // The main method is the entry point for all Java programs
    public static void main(String[] args) {
        // Declare and initialise the astronaut list
        ArrayList<String> astronauts = new ArrayList<String>();
        astronauts.add("Sergey Prokopyev");
        astronauts.add("Frank Rubio");
        astronauts.add("Stephen Bowen");

        // Use Scanner for reading user input from the console
        Scanner scanner = new Scanner(System.in);

        // Ask the user to input another astronaut
        System.out.println("Enter the name of another astronaut:");
        String name = scanner.nextLine();

        // Add the name to the end of the list
        astronauts.add(name);

        // Output the astronaut list
        displayAstronauts(astronauts);
    }

    // Display the values from the given astronaut list
    public static void displayAstronauts(ArrayList<String> astronauts) {
        System.out.println("\nAstronauts:");

        // Repeat for each value in the list
        for (String name : astronauts) {
            System.out.println(name);
        }
    }
}