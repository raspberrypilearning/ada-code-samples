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

import java.util.Scanner;

class Selection
{
    // The main method is the entry point for all Java programs
    public static void main(String[] args)
    {
        rentCheck();
    }


    // Example of nested selection to check user can rent a flat
    public static void rentCheck()
    {
        // Use Scanner for reading user input from the console
        Scanner scanner = new Scanner(System.in);

        System.out.println("Enter your age: ");
        String inputAge = scanner.nextLine();
        int age = Integer.parseInt(inputAge);

        if (age >= 21) {
            System.out.println("Enter your salary: ");
            String inputSalary = scanner.nextLine();
            int salary = Integer.parseInt(inputSalary);

            if (salary > 15000) {
                System.out.println("You can rent the flat");
            }
            else {
                System.out.println("You don't earn enough to rent the flat");
            }
        }
        else if (age >= 18 && age < 21) {
            System.out.println("Do you have a guarantor (yes/no): ");
            String guarantor = scanner.nextLine();

            if ("yes".equals(guarantor)) {
                System.out.println("We will need to contact your guarantor");
            }
            else {
                System.out.println("I am sorry but you need a guarantor");
            }
        }
        else {
            System.out.println("I am sorry but you can't rent the flat");
        }
    }


}