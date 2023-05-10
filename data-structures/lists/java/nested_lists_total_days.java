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

        // Calculate the total number of days in space
        int total = calculateTotalDays(allAstronauts);
        System.out.println("Total number of days in space: " + total);
    }

    // Calculate and return the sum of all the astronauts' days in space
    public static int calculateTotalDays(ArrayList<ArrayList<String>> allAstronauts) {
        int totalDays = 0;

        // Repeat for each astronaut in the outer list
        for (ArrayList<String> astronaut : allAstronauts) {
            // Add the number of days to the total
            totalDays += Integer.parseInt(astronaut.get(DAYS_INDEX));
        }

        return totalDays;
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