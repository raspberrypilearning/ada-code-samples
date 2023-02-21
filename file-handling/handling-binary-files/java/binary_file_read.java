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

import java.io.BufferedInputStream;
import java.io.DataInputStream;
import java.io.FileInputStream;
import java.io.IOException;
import java.io.EOFException;
import java.util.HashMap;
import java.util.Map;

class HandlingBinaryFiles
{
    // The main method is the entry point for all Java programs
    public static void main(String[] args)
    {
        readBinaryFile();
    }


    // Read data from a binary file
    public static void readBinaryFile()
    {
        Map<String, Double> playerStats = new HashMap<String, Double>();

        String filename = "treasure.game";

        // Uses try-with-resources to automatically close the readers after execution
        try (FileInputStream fis = new FileInputStream(filename);
             BufferedInputStream bis = new BufferedInputStream(fis);
             DataInputStream dis = new DataInputStream(bis)) {

            boolean endOfFile = false;
            while (!endOfFile) {
                try {
                    String key = dis.readUTF();
                    double value = dis.readDouble();
                    playerStats.put(key, value);
                }
                catch (EOFException e) {
                    endOfFile = true;
                }
            }
        } // The readers are now closed
        catch (IOException e) {
            e.printStackTrace();
        }

        // Testing the hash map has been populated from the binary file
        System.out.println("Output the hash map read from the binary file");
        for (String key : playerStats.keySet()) {
            System.out.println("Key: " + key + ", Value: " + playerStats.get(key));
        }
    }


}