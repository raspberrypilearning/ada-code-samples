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

class GoodProgrammingPractice {
    static final double GRAVITY_ON_EARTH = 9.81;
    static final double GRAVITY_ON_MARS = 3.711;

    // The main method is the entry point for all Java programs
    public static void main(String[] args) {
        // Execute both subroutines and output the results
        double weight = 35.7;
        System.out.println(conv(weight));
        System.out.println(calculateWeightOnMars(weight));
    }


    // First example
    public static double conv(double a) {
        double b = a / 9.81 * 3.711;
        return b;
    }


    // Second example
    // Convert a weight on Earth to the weight on Mars based on gravity
    public static double calculateWeightOnMars(double weightOnEarth) {
        double weightOnMars = weightOnEarth / GRAVITY_ON_EARTH * GRAVITY_ON_MARS;
        return weightOnMars;
    }


}