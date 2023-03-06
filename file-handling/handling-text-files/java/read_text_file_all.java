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

import java.io.IOException;
import java.nio.file.Files;
import java.nio.file.Path;

class HandlingTextFiles
{
    // The main method is the entry point for all Java programs
    public static void main(String[] args) {
        readAll();
    }

    
    // Read all the text of a file
    public static void readAll() {
        try {
            Path filePath = Path.of("bridge.txt");
            String rhyme = Files.readString(filePath);
            System.out.println(rhyme);
        }
        catch (IOException e) {
            e.printStackTrace();
        }
    }


}