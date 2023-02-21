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
import java.util.Scanner;

class HandlingCSVFiles
{
    // The main method is the entry point for all Java programs
    public static void main(String[] args)
    {
        // Use Scanner for reading user input from the console
        Scanner scanner = new Scanner(System.in);

        System.out.println("Enter the title of the film: ");
        String title = scanner.nextLine();

        System.out.println("Enter the year the film was made: ");
        String year = scanner.nextLine();

        System.out.println("Enter the length of the film in minutes: ");
        String duration = scanner.nextLine();

        System.out.println("Enter the name of the film director: ");
        String director = scanner.nextLine();
        
        System.out.println("Enter the average film rating: ");
        String rating = scanner.nextLine();

        System.out.println("Enter the takings in US$ millions: ");
        String takings = scanner.nextLine();

        appendMovieOptimised(title, year, duration, director, rating, takings);
    }


    // Optimised version to append a new record to the CSV file
    public static void appendMovieOptimised(String title, String year, String duration, String director, String rating, String takings)
    {
        String newMovie = title + "," + year + "," + duration + "," + director + "," + rating + "," + takings;

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