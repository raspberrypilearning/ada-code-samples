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

class StringValidation
{
    // The main method is the entry point for all Java programs
    public static void main(String[] args)
    {
        // normal test data
        String password = "elephant1234";
        boolean result = checkPassword(password);
        System.out.println(password + " is valid: " + result);

        // boundary test data
        password = "elephant";  // 8 characters exactly
        result = checkPassword(password);
        System.out.println(password + " is valid: " + result);

        // password is too short
        password = "1234";
        result = checkPassword(password);
        System.out.println(password + " is valid: " + result);
    }


    // Checks password length
    public static boolean checkPassword(String password)
    {
        boolean isValid = true;

        if (password.length() < 8) {
            isValid = false;
        }

        return isValid;
    }


}