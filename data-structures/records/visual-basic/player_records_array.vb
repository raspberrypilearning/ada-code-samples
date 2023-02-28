' Raspberry Pi Foundation
' Developed as part of Ada Computer Science
' Usage licensed under CC BY-NC-SA 4.0
' Note: This file is designed to be copied out and compiled on your machine.
' To run this file you need to:
' 1. Copy the contents
' 2. Paste them into the Visual Basic IDE of your choice (Visual Studio, for example)
' 3. Compile the program
' 4. Run the program


'Define a record strcuture
Structure PlayerRecord
    Dim playerNumber As Integer
    Dim firstName As String
    Dim lastName As String
    Dim dateOfBirth As Date
    Dim position As String
    Dim injured As Boolean
End Structure


Module Program

    'The Main method is the default entry point for all VB programs
    Sub Main()
        ' Declare an array to store 11 player records
        Dim firstTeam(10) As PlayerRecord

        ' Testing - create 4 players and add them to the array
        Dim player1 As PlayerRecord = CreatePlayer(1, "Maria", "Oarps", 3, 7, 1994, "Goalkeeper", False)
        firstTeam(0) = player1

        Dim player2 As PlayerRecord = CreatePlayer(2, "Lucie", "Gold", 18, 10, 1991, "Defender", True)
        firstTeam(1) = player2

        Dim player3 As PlayerRecord = CreatePlayer(3, "Raquel", "Weekly", 12, 6, 1992, "Defender", False)
        firstTeam(2) = player3

        Dim player4 As PlayerRecord = CreatePlayer(4, "Kiera", "Welsh", 4, 8, 1998, "Midfielder", False)
        firstTeam(3) = player4

        ' Display information about each player
        DisplayPlayers(firstTeam)
    End Sub


    ' Create a new player record with the given data
    Function CreatePlayer(ByVal pId As Integer, ByVal fName As String, ByVal lName As String, ByVal day As Integer, ByVal month As Integer, ByVal year As Integer, ByVal pos As String, ByVal inj As Boolean) As PlayerRecord
        ' Create a new player record
        Dim player As PlayerRecord

        ' Store the details of the player
        player.playerNumber = pId
        player.firstName = fName
        player.lastName = lName
        player.dateOfBirth = New DateTime(year, month, day)
        player.position = pos
        player.injured = inj

        ' Return the player record
        Return player
    End Function


    ' Display some of the player details from each player record
    Sub DisplayPlayers(ByVal playersArray As PlayerRecord())
        Console.WriteLine("### Displaying array of player records ###")

        ' Repeat for each player in the players array of records
        For Each player As PlayerRecord In playersArray
            ' Display the player's number, name and position
            Console.WriteLine($"Number: {player.playerNumber}")
            Console.WriteLine($"Name: {player.firstName} {player.lastName}")
            Console.WriteLine($"Position: {player.position}")
        Next
    End Sub


End Module
