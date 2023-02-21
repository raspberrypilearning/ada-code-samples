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

class HashTables
{
    // The main method is the entry point for all Java programs
    public static void main(String[] args)
    {
        // Generate a hash value from an integer hash key
        String key = "A5RD";
        int slots = 97;
        int value = hashString(key, slots);
        System.out.println("Hash value for " + key + " is " + value);
    }

    // Produce a hash value from a string
    public static int hashString(String hashKey, int numberOfSlots)
    {
        // Initialise total
        int total = 0;

        // Repeat for every character in the hash key
        for (int i = 0; i < hashKey.length(); i++) {
            // Add the character's ASCII value to the total
            int asciiCode = hashKey.charAt(i);
            total = total + asciiCode;
        }

        // Generate the hash value using the modulo operator
        int hashValue = total % numberOfSlots;

        // Return the hash value
        return hashValue;
    }


}