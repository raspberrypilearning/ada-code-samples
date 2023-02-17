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

class OneDimensionalArrays
{
    // The main method is the entry point for all Java programs
    public static void main(String[] args)
    {
        String[] emotions = new String[6]; // Declare an array of 6 elements

        emotions[0] = "amazed";  // Assign a value into a position of the array
        emotions[1] = "delighted";
        emotions[2] = "ecstatic";
        emotions[3] = "enthusiastic";
        emotions[4] = "lively";

        System.out.println(emotions[2]);  // Displays the third element of the array

        emotions[5] = "happy";  // Adds a new item to the array

        emotions[1] = "";  // Deletes the item in the second element of the array
    }


}