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
        astronauts.add("Frank Rubio");
        astronauts.add("Stephen Bowen");
        astronauts.add("Sultan Al Neyadi");

        // Use Scanner for reading user input from the console
        Scanner scanner = new Scanner(System.in);

        // Ask the user for an astronaut's name
        System.out.println("Enter the full name of an astronaut to find:");
        String nameToFind = scanner.nextLine();

        // Check if the name matches a value in the astronaut list
        boolean found = checkNameExists(astronauts, nameToFind);

        // Output the search results
        if (found) {
            System.out.println("Astronaut found!");
        }
        else {
            System.out.println("Astronaut not found in this data set");
        }
    }

    // Return true if the search value is found in the list
    public static boolean checkNameExists(ArrayList<String> astronauts, String searchName) {
        int i = 0;
        boolean isFound = false;

        // Repeat while the search name has not been found
        while (!isFound && i < astronauts.size()) {
            // Check if the current name equals the search name
            if (astronauts.get(i).equals(searchName)) {
                isFound = true;
            }
            i += 1; // Increment the counter
        }

        return isFound;
    }
}