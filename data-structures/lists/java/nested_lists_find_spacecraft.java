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

class NestedLists  {
    // Index values of each astronaut
    public static final int CRAFT_INDEX = 0;
    public static final int NAME_INDEX = 1;
    public static final int DAYS_INDEX = 2;

    // The main method is the entry point for all Java programs
    public static void main(String[] args) {
        // Declare and initialise the nested list of astronauts
        ArrayList<ArrayList<String>> allAstronauts = new ArrayList<ArrayList<String>>();
        initialiseAstronauts(allAstronauts);

        // Use Scanner for reading user input from the console
        Scanner scanner = new Scanner(System.in);

        // Find all the astronauts on a spacecraft
        System.out.println("Get a list of all astronauts that are on a specific spacecraft");
        System.out.println("Enter the spacecraft name:");
        String spacecraft = scanner.nextLine();
        ArrayList<ArrayList<String>> foundAstronauts = getAstronautsBySpacecraft(allAstronauts, spacecraft);

        // Output the search results
        if (foundAstronauts.size() == 0) {
            System.out.println("\nNo astronauts found in the spacecraft " + spacecraft);
        }
        else {
            System.out.println("\nAstronauts found:");
            displayAllAstronauts(foundAstronauts);
        }
    }

    // Return a list of astronauts that are on a given spacecraft
    public static ArrayList<ArrayList<String>> getAstronautsBySpacecraft(
            ArrayList<ArrayList<String>> allAstronauts, String givenSpacecraft) {

        // Declare a list to store the found astronauts in
        ArrayList<ArrayList<String>> foundList = new ArrayList<ArrayList<String>>();

        // Repeat for all astronauts in the outer list using the index i
        for (int i = 0; i < allAstronauts.size(); i++) {
            // Check if the astronaut is in the spacecraft
            if (givenSpacecraft.equals(allAstronauts.get(i).get(CRAFT_INDEX))) {
                foundList.add(allAstronauts.get(i));
            }
        }

        return foundList;
    }

    // Display the values of each astronaut in the given list
    public static void displayAllAstronauts(ArrayList<ArrayList<String>> allAstronauts) {
        // Repeat for each astronaut in the outer list
        for (ArrayList<String> astronaut : allAstronauts) {
            // Repeat for each value in the inner list
            for (String value : astronaut) {
                System.out.print(value + "  "); // Do not print new line
            }
            System.out.println(); // Print a new line after each astronaut
        }
    }

    // Initialise the nested list of astronauts
    public static void initialiseAstronauts(ArrayList<ArrayList<String>> allAstronauts) {
        ArrayList<String> first = new ArrayList<String>();
        first.add("ISS");
        first.add("Sergey Prokopyev");
        first.add("176");
        allAstronauts.add(first);

        ArrayList<String> second = new ArrayList<String>();
        second.add("ISS");
        second.add("Dmitry Petelin");
        second.add("176");
        allAstronauts.add(second);

        ArrayList<String> third = new ArrayList<String>();
        third.add("ISS");
        third.add("Frank Rubio");
        third.add("176");
        allAstronauts.add(third);

        ArrayList<String> fourth = new ArrayList<String>();
        fourth.add("Tiangong");
        fourth.add("Fei Junlong");
        fourth.add("112");
        allAstronauts.add(fourth);

        ArrayList<String> fifth = new ArrayList<String>();
        fifth.add("Tiangong");
        fifth.add("Deng Qingming");
        fifth.add("107");
        allAstronauts.add(fifth);

        ArrayList<String> sixth = new ArrayList<String>();
        sixth.add("Tiangong");
        sixth.add("Zhang Lu");
        sixth.add("107");
        allAstronauts.add(sixth);

        ArrayList<String> seventh = new ArrayList<String>();
        seventh.add("ISS");
        seventh.add("Stephen Bowen");
        seventh.add("54");
        allAstronauts.add(seventh);

        ArrayList<String> eighth = new ArrayList<String>();
        eighth.add("ISS");
        eighth.add("Warren Hoburg");
        eighth.add("14");
        allAstronauts.add(eighth);

        ArrayList<String> ninth = new ArrayList<String>();
        ninth.add("ISS");
        ninth.add("Sultan Al Neyadi");
        ninth.add("14");
        allAstronauts.add(ninth);

        ArrayList<String> tenth = new ArrayList<String>();
        tenth.add("ISS");
        tenth.add("Andrey Fedyaev");
        tenth.add("14");
        allAstronauts.add(tenth);
    }
}