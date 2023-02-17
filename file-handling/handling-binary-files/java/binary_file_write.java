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

import java.io.BufferedOutputStream;
import java.io.DataOutputStream;
import java.io.FileOutputStream;
import java.io.IOException;
import java.util.HashMap;
import java.util.Map;

class HandlingBinaryFiles
{
    // The main method is the entry point for all Java programs
    public static void main(String[] args)
    {
        Map<String, Double> playerStats = new HashMap<String, Double>();
        playerStats.put("health", 100.0);
        playerStats.put("hunger", 10.0);
        playerStats.put("money", 20.00);
        playerStats.put("lives", 3.0);

        writeBinaryFile(playerStats);
    }


    // Write data to a binary file
    public static void writeBinaryFile(Map<String, Double> stats)
    {
        String filename = "treasure.game";

        // Uses try-with-resources to automatically close the writers after execution
        try (FileOutputStream fos = new FileOutputStream(filename);
             BufferedOutputStream bos = new BufferedOutputStream(fos);
             DataOutputStream dos = new DataOutputStream(bos)) {

            for (String key : stats.keySet()) {
                dos.writeUTF(key);
                dos.writeDouble(stats.get(key));
            }
        } // The writers are now closed
        catch (IOException e) {
            e.printStackTrace();
        }
    }


}