' Raspberry Pi Foundation
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
        'Create a player record
        Dim player1 As PlayerRecord

        'Store the details of the player
        player1.playerNumber = 1
        player1.firstName = "Maria"
        player1.lastName = "Oarps"
        player1.dateOfBirth = New DateTime(1994, 7, 3)
        player1.position = "Goalkeeper"
        player1.injured = False

        'Display the player's name and position
        Console.WriteLine("### Details from player record ###")
        Console.WriteLine($"Name: {player1.firstName} {player1.lastName}")
        Console.WriteLine($"Position: {player1.position}")
    End Sub


End Module
