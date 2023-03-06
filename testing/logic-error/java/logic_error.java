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

class LogicErrors
{
    // The main method is the entry point for all Java programs
    public static void main(String[] args) {
        double amount = 130.40;
        double result = addVat(amount);
        System.out.println(result);
    }


    // Calculates and applies VAT at standard rate
    public static double addVat(double amount) {
        // Demonstrates a logic error
        int RATE = 20;
        double vat = amount * RATE;
        double withVat = amount + vat;
        return withVat;
    }


}