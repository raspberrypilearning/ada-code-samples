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

class SingleDictionaries  {
    // The main method is the entry point for all Java programs
    public static void main(String[] args) {
        // Declare and initialise the astronaut dictionary
        HashMap<String, String> astronaut = new HashMap<String, String>();
        astronaut.put("craft", "ISS");
        astronaut.put("name", "Sultan Al Neyadi");
        astronaut.put("days", "14");

        // Update the days in space of the astronaut
        astronaut.put("days", "18");

        // Output the updated number of days
        String newDays = astronaut.get("days");
        System.out.println("The days in space has been changed to " + newDays);
    }
}