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

class NestedDictionaries  {
    // The main method is the entry point for all Java programs
    public static void main(String[] args) {
        // Declare and initialise the astronaut dictionary
        var astronautsByName = new HashMap<String, HashMap<String, String>>();
        initialiseAstronauts(astronautsByName);

        // Use Scanner for reading user input from the console
        Scanner scanner = new Scanner(System.in);

        // Ask the user to input the new astronaut's details
        System.out.println("Enter the astronaut's full name:");
        String name = scanner.nextLine();
        System.out.println("Enter the name of the spacecraft:");
        String spacecraft = scanner.nextLine();
        System.out.println("Enter the current number of days in space:");
        String days = scanner.nextLine();

        // Add the new astronaut to the list
        addNewAstronaut(astronautsByName, name, spacecraft, days);

        // Output the details of the new astronaut
        System.out.println("\nAstronaut name: " + name);
        var astronaut = astronautsByName.get(name);
        displayKeyValuePairs(astronaut);
    }

    // Add a new astronaut dictionary to the nested dictionary
    public static void addNewAstronaut(
            HashMap<String, HashMap<String, String>> astronautsByName,
            String givenName, String givenSpacecraft, String givenDays) {

        // Create a new dictionary for the astronaut
        var newAstronaut = new HashMap<String, String>();
        newAstronaut.put("craft", givenSpacecraft);
        newAstronaut.put("days", givenDays);

        // Add the new astronaut dictionary to the nested dictionary
        astronautsByName.put(givenName, newAstronaut);
    }

    // Display the key-value pairs from the given astronaut dictionary
    public static void displayKeyValuePairs(HashMap<String, String> astronaut) {
        System.out.println("Astronaut dictionary:");

        // Repeat for each key-value pair in the dictionary
        for (String key : astronaut.keySet()) {
            String value = astronaut.get(key);
            System.out.println("Key: " + key + ", value: " + value);
        }
    }

    // Initialise the nested dictionary of astronauts
    public static void initialiseAstronauts(HashMap<String, HashMap<String, String>> astronautsByName) {
        var first = new HashMap<String, String>();
        first.put("craft", "ISS");
        first.put("days", "176");
        astronautsByName.put("Sergey Prokopyev", first);

        var second = new HashMap<String, String>();
        second.put("craft", "ISS");
        second.put("days", "176");
        astronautsByName.put("Dmitry Petelin", second);

        var third = new HashMap<String, String>();
        third.put("craft", "ISS");
        third.put("days", "176");
        astronautsByName.put("Frank Rubio", third);

        var fourth = new HashMap<String, String>();
        fourth.put("craft", "Tiangong");
        fourth.put("days", "112");
        astronautsByName.put("Fei Junlong", fourth);

        var fifth = new HashMap<String, String>();
        fifth.put("craft", "Tiangong");
        fifth.put("days", "107");
        astronautsByName.put("Deng Qingming", fifth);

        var sixth = new HashMap<String, String>();
        sixth.put("craft", "Tiangong");
        sixth.put("days", "107");
        astronautsByName.put("Zhang Lu", sixth);

        var seventh = new HashMap<String, String>();
        seventh.put("craft", "ISS");
        seventh.put("days", "54");
        astronautsByName.put("Stephen Bowen", seventh);

        var eighth = new HashMap<String, String>();
        eighth.put("craft", "ISS");
        eighth.put("days", "14");
        astronautsByName.put("Warren Hoburg", eighth);

        var ninth = new HashMap<String, String>();
        ninth.put("craft", "ISS");
        ninth.put("days", "14");
        astronautsByName.put("Sultan Al Neyadi", ninth);

        var tenth = new HashMap<String, String>();
        tenth.put("craft", "ISS");
        tenth.put("days", "14");
        astronautsByName.put("Andrey Fedyaev", tenth);
    }
}