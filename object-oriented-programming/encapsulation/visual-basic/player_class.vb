' Raspberry Pi Foundation
' Usage licensed under CC BY-NC-SA 4.0
' Note: This file is designed to be copied out and compiled on your machine.
' To run this file you need to:
' 1. Copy the contents
' 2. Paste them into the Visual Basic IDE of your choice (Visual Studio, for example)
' 3. Compile the program
' 4. Run the program


Class Player

    Private name As String
    Private score As Integer

    ' Constructor method
    Public Sub New(ByVal givenName As String)
        name = givenName
        score = 0
    End Sub

    Public Function GetName()
        Return name
    End Function


    Public Function GetScore()
        Return score
    End Function


    Public Sub SetScore(ByVal newScore As Integer)
        score = newScore
    End Sub

End Class


Module Program

    ' The Main method is the default entry point for all VB programs
    Sub Main()
        ' Instantiate a new player object
        Dim gamePlayer As Player = New Player("Leona")
        
        Dim playerName As String = gamePlayer.GetName()
        Console.WriteLine($"The player's name is: {playerName}")

        Dim playerScore As Integer = gamePlayer.GetScore()
        Console.WriteLine($"The player's score is: {playerScore}")
        
        gamePlayer.setScore(20)
        playerScore = gamePlayer.GetScore()
        Console.WriteLine($"The player's score is now: {playerScore}")
    End Sub


End Module
