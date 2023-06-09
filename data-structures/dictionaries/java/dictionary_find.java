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

import java.util.HashMap;
import java.util.Scanner;

class SingleDictionaries  {
    // The main method is the entry point for all Java programs
    public static void main(String[] args) {
        // Declare and initialise the astronaut dictionary
        HashMap<String, String> astronaut = new HashMap<String, String>();
        astronaut.put("craft", "ISS");
        astronaut.put("name", "Sultan Al Neyadi");
        astronaut.put("days", "14");
        astronaut.put("country", "United Arab Emirates");

        // Use Scanner for reading user input from the console
        Scanner scanner = new Scanner(System.in);

        // Ask the user for a key to find
        System.out.println("Enter a key to find:");
        String inputKey = scanner.nextLine();

        // Check if the key exists in the dictionary
        if (astronaut.containsKey(inputKey)) {
            System.out.println("Key exists!");
            String value = astronaut.get(inputKey);
            System.out.println("Key: " + inputKey + ", value: " + value);
        }
        else {
            System.out.println("That key does not exist");
        }
    }
}