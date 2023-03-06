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

class Boat {
    private String name;
    private float length;
    private int capacity;
    private int berths;
    protected float unitCost;

    // Constructor method
    public Boat(String givenName, float givenLength, int givenCapacity,
                int givenBerths, float givenUnitCost) {
        name = givenName;
        length = givenLength;
        capacity = givenCapacity;
        berths = givenBerths;
        unitCost = givenUnitCost;
    }
}


class Testing {
    // The main method is the entry point for all Java programs
    public static void main(String[] args) {
        String name = "Sir David Attenborough";
        float length = 128.9F;
        int capacity = 88;
        int berths = 90;
        float cost = 200000000F;

        // Instantiate a new boat object
        Boat boaty = new Boat(name, length, capacity, berths, cost);

        // Show that the boat object has been created
        System.out.println(boaty);
    }


}