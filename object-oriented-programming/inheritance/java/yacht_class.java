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


// Yacht class inherits from the Boat class
class Yacht extends Boat
{
    private int masts;

    // Constructor method
    public Yacht(String givenName, float givenLength, int givenCapacity,
                 int givenBerths, float givenUnitCost, int givenMasts) {
        // Invoke the constructor of the base-class (Boat)
        super(givenName, givenLength, givenCapacity, givenBerths, givenUnitCost);

        // Set the additional attribute which is unique to Yacht
        masts = givenMasts;
    }
}


class Testing {
    // The main method is the entry point for all Java programs
    public static void main(String[] args) {
        // Instantiate a new yacht object
        Yacht myYacht = new Yacht("Mary Sue", 15.7F, 300, 6, 54.5F, 2);

        // Show that the yacht object has been created
        System.out.println(myYacht);
    }


}