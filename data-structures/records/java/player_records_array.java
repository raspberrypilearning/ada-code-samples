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
        // Declare an array to store 11 player records
        PlayerRecord[] firstTeam = new PlayerRecord[11];

        // Testing - create 4 players and add them to the array
        PlayerRecord player1 = createPlayer(1, "Maria", "Oarps",
                3, 7, 1994, "Goalkeeper", false);
        firstTeam[0] = player1;

        PlayerRecord player2 = createPlayer(2, "Lucie", "Gold",
                18, 10, 1991, "Defender", true);
        firstTeam[1] = player2;

        PlayerRecord player3 = createPlayer(3, "Raquel", "Weekly",
                12, 6, 1992, "Defender", false);
        firstTeam[2] = player3;

        PlayerRecord player4 = createPlayer(4, "Kiera", "Welsh",
                4, 8, 1998, "Midfielder", false);
        firstTeam[3] = player4;

        // Display information about each player
        displayPlayers(firstTeam);
    }


    // Create a new player record with the given data
    public static PlayerRecord createPlayer(int pId, String fName, String lName,
                                            int day, int month, int year,
                                            String pos, boolean inj)
    {
        // Create a new player record
        PlayerRecord player = new PlayerRecord();

        // Store the details of the player
        player.playerNumber = pId;
        player.firstName = fName;
        player.lastName = lName;
        player.dateOfBirth = LocalDate.of(year, month, day);
        player.position = pos;
        player.injured = inj;

        // Return the player record
        return player;
    }


    // Display some of the player details from each player record
    public static void displayPlayers(PlayerRecord[] playersArray)
    {
        System.out.println("### Array of player records ###");

        // Repeat for each player in the players array of records
        for (PlayerRecord player : playersArray) {
            // Check if the player record exists
            if (player != null) {
                // Display the player's number, name and position
                System.out.println("\nNumber: " + player.playerNumber);
                System.out.println("Name: " + player.firstName + " " + player.lastName);
                System.out.println("Position: " + player.position);
            }
        }
    }


}