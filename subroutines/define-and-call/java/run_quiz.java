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

class DefineAndCall
{
    // The main method is the entry point for all Java programs
    public static void main(String[] args)
    {
        // Use Scanner for reading user input from the console
        Scanner scanner = new Scanner(System.in);

        System.out.println("What is your name? ");
        String name = scanner.nextLine();
        System.out.println("Greetings " + name);

        runQuiz();
        System.out.println("End of the quiz");
    }


    // Simulates a quiz
    public static void runQuiz()
    {
        // Use Scanner for reading user input from the console
        Scanner scanner = new Scanner(System.in);

        System.out.println("What is the capital city of Botswana?");
        String answer = scanner.nextLine();

        if ("Gaborone".equals(answer)) {
            System.out.println("Well done!");
        }
        else {
            System.out.println("Sorry! That is the wrong answer");
        }
    }


}