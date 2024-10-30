/*
Raspberry Pi Foundation
Developed as part of Ada Computer Science 
Usage licensed under CC BY-NC-SA 4.0

Note: This file is designed to be copied out and compiled on your machine.
In order for it to compile properly you need to ensure that the project name is the same as the "namespace" in this file.
To run this file you need to:
1. Copy the contents
2. Paste them into the C# IDE of your choice (Visual Studio, for example)
3. Change the namespace to match your project (if necessary)
4. Compile the program
5. Run the program
*/

using System;

namespace AdaCodeSamples {
    // Use a class to represent a player as a record
    // Note: In C# 9 you can use record or record class 
    //       and in C# 10 you can use record struct
    class PlayerRecord {
        public int playerNumber;
        public string firstName;
        public string lastName;
        public DateTime dateOfBirth;
        public string position;
        public bool injured;
    }


    class Testing {
        // The Main method is the entry point for all C# programs
        public static void Main() {
            // Create a new player record
            PlayerRecord player1 = new PlayerRecord();

            // Store the details of the player
            player1.playerNumber = 1;
            player1.firstName = "Maria";
            player1.lastName = "Oarps";
            player1.dateOfBirth = new DateTime(1994, 7, 3);
            player1.position = "Goalkeeper";
            player1.injured = false;

            // Display the player's name and position
            Console.WriteLine("### Player record ###");
            Console.WriteLine($"Name: {player1.firstName} {player1.lastName}");
            Console.WriteLine($"Position: {player1.position}");
        }

        
    }
}