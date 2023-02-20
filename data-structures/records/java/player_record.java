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

import java.time.LocalDate;

// Use a class to represent a player as a record
class PlayerRecord
{
    public int playerNumber;
    public String firstName;
    public String lastName;
    public LocalDate dateOfBirth;
    public String position;
    public boolean injured;
}


class DataStructures
{
    // The main method is the entry point for all Java programs
    public static void main(String[] args)
    {
        // Create a player record and store the player details
        PlayerRecord player1 = new PlayerRecord();

        // Store the details of the player
        player1.playerNumber = 1;
        player1.firstName = "Maria";
        player1.lastName = "Oarps";
        player1.dateOfBirth = LocalDate.of(1994, 7, 3);
        player1.position = "Goalkeeper";
        player1.injured = false;

        // Display the player's name and position
        System.out.println("### Player record ###");
        System.out.println("Name: " + player1.firstName + " " + player1.lastName);
        System.out.println("Position: " + player1.position);
    }


}