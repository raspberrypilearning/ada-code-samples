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

class HashTables
{
    // The main method is the entry point for all Java programs
    public static void main(String[] args)
    {
        // Generate a hash value from an integer hash key
        int key = 12345;
        int slots = 97;
        int value = hashInteger(key, slots);
        System.out.println("Hash value for " + key + " is " + value);
    }

    // Produce a hash value from an integer
    public static int hashInteger(int hashKey, int numberOfSlots)
    {
        // Generate the hash value using the modulo operator
        int hashValue = hashKey % numberOfSlots;

        // Return the hash value
        return hashValue;
    }


}