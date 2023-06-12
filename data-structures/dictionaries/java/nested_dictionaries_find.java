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

        // Ask the user for a key to find
        System.out.println("Enter a key (astronaut name):");
        String inputKey = scanner.nextLine();

        // Check if the key exists in the nested dictionary
        if (astronautsByName.containsKey(inputKey)) {
            System.out.println("Key exists!");
            HashMap<String, String> value = astronautsByName.get(inputKey);
            System.out.println("Key: " + inputKey + ", value: " + value);
        }
        else {
            System.out.println("That key does not exist");
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
        fourth.put("craft", "Shenzhou 15");
        fourth.put("days", "112");
        astronautsByName.put("Fei Junlong", fourth);

        var fifth = new HashMap<String, String>();
        fifth.put("craft", "Shenzhou 15");
        fifth.put("days", "107");
        astronautsByName.put("Deng Qingming", fifth);

        var sixth = new HashMap<String, String>();
        sixth.put("craft", "Shenzhou 15");
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