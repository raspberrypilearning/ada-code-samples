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

class RecursionExamples
{
    // The main method is the entry point for all Java programs
    public static void main(String[] args)
    {
        int n = 5;
        int result = factorial(n);
        System.out.println(n + "! is: " + result);
    }


    // Returns the value of n!
    public static int factorial(int n)
    {
        if (n == 1) {
            return 1;
        }
        else {
            return n * factorial(n-1);
        }
    }


}