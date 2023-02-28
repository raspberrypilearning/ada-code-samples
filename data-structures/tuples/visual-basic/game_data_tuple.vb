' Raspberry Pi Foundation
' Developed as part of Ada Computer Science
' Usage licensed under CC BY-NC-SA 4.0
' Note: This file is designed to be copied out and compiled on your machine.
' To run this file you need to:
' 1. Copy the contents
' 2. Paste them into the Visual Basic IDE of your choice (Visual Studio, for example)
' 3. Compile the program
' 4. Run the program

Module program

    ' The Main method is the default entry point for all VB programs
    Sub Main()
        ' Return a tuple of 3 elements representing data in a game
        ' playerName, level, time
        Dim gameData As Tuple(Of String, Integer, Single) = LoadGameData()

        'Output the values of the tuple
        Console.WriteLine($"Player: {gameData.Item1}")
        Console.WriteLine($"Level: {gameData.Item2}")
        Console.WriteLine($"Time played (seconds): {gameData.Item3}")
    End Sub


    ' Demonstrates returning a tuple of multiple data types
    Function LoadGameData() As Tuple(Of String, Integer, Single)
        Dim playerName As String = "TopGamer99"
        Dim level As Integer = 5
        Dim time As Single = 764.312f

        ' Create and return a tuple containing 3 elements
        Return Tuple.Create(playerName, level, time)
    End Function


End Module
