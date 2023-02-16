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

import java.io.BufferedWriter;
import java.io.FileWriter;
import java.io.IOException;
import java.io.PrintWriter;

class HandlingTextFiles
{
    // The main method is the entry point for all Java programs
    public static void main(String[] args)
    {
        writeToFile();
    }


    // Example of writing to a text file
    public static void writeToFile()
    {
        // Uses try-with-resources to automatically close the writers after execution
        try (FileWriter fw = new FileWriter("twinkle.txt", false);
             BufferedWriter bw = new BufferedWriter(fw);
             PrintWriter pw = new PrintWriter(bw)) {

            pw.println("Twinkle, twinkle, little star,");
            pw.println("How I wonder what you are!");
            pw.println("Up above the world so high,");
            pw.println("Like a diamond in the sky.");
        } // The writers are now closed
        catch (IOException e) {
            e.printStackTrace();
        }
    }


}