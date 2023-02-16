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

class HandlingCSVFiles
{
    // The main method is the entry point for all Java programs
    public static void main(String[] args)
    {
        readCsv();
    }


    // Read and display the records from a CSV file
    public static void readCsv()
    {
        // Uses try-with-resources to automatically close the readers after execution
        try (FileReader fr = new FileReader("movies.csv");
             BufferedReader reader = new BufferedReader(fr)) {

            String record = reader.readLine();

            while (record != null) {
                String[] movieData = record.split(",");
                String title = movieData[0];
                String rating = movieData[4];
                System.out.println("Movie name: " + title + ", Rating: " + rating);
                record = reader.readLine(); // Read the next line
            }
        } // The readers are now closed
        catch (IOException e) {
            e.printStackTrace();
        }
    }


}