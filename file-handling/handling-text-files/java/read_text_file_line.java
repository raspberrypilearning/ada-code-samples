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

import java.io.BufferedReader;
import java.io.FileReader;
import java.io.IOException;

class HandlingTextFiles
{
    // The main method is the entry point for all Java programs
    public static void main(String[] args)
    {
        readLineOfFile();
    }


    // Read and display a single line of the file
    public static void readLineOfFile()
    {
        String rhymeLine = "";

        // Uses try-with-resources to automatically close the readers after execution
        try (FileReader fr = new FileReader("bridge.txt");
             BufferedReader reader = new BufferedReader(fr)) {

            rhymeLine = reader.readLine();
        } // The readers are now closed
        catch (IOException e) {
            e.printStackTrace();
        }

        System.out.println(rhymeLine);
    }


}