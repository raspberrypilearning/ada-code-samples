/*
Raspberry Pi Foundation
Developed to be used alongside Isaac Computer Science,
part of the National Centre for Computing Education
Usage licensed under CC BY-SA 4

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

import java.util.Scanner;

class CallStack
{
    // The main method is the entry point for all Java programs
    public static void main(String[] args)
    {
        // Use Scanner for reading user input from the console
        Scanner scanner = new Scanner(System.in);

        // Demonstrates the use of call stacks
        System.out.println("Please enter a number");
        String num1String = scanner.nextLine();
        int num1 = Integer.parseInt(num1String);

        System.out.println("Please enter another number");
        String num2String = scanner.nextLine();
        int num2 = Integer.parseInt(num2String);

        calculateProduct(num1, num2);
    }


    // Calculates the product of two numbers
    public static void calculateProduct(int n1, int n2)
    {
        int product = n1 * n2;
        System.out.println(product);
    }


}