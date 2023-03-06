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

import java.io.BufferedWriter;
import java.io.FileWriter;
import java.io.IOException;

class HandlingCSVFiles
{
    // The main method is the entry point for all Java programs
    public static void main(String[] args) {
        appendMovie();
    }


    // Append a new record to the CSV file
    public static void appendMovie() {
        String newMovie = "CODA,2021,111,Sian Heder,8.1,1.5";

        // Uses try-with-resources to automatically close the writers after execution
        try (FileWriter fw = new FileWriter("movies.csv", true);
             BufferedWriter writer = new BufferedWriter(fw)) {

            writer.write(newMovie);
            writer.newLine();
        } // The writers are now closed
        catch (IOException e) {
            e.printStackTrace();
        }
    }


}