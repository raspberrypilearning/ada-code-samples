' Raspberry Pi Foundation
' Usage licensed under CC BY-SA 4
' Note: This file is designed to be copied out and compiled on your machine.
' To run this file you need to:
' 1. Copy the contents
' 2. Paste them into the Visual Basic IDE of your choice (Visual Studio, for example)
' 3. Compile the program
' 4. Run the program


Class PlayingCard
    Private suit As String
    Private rank As String
    Private value As Integer

    ' Constructor method
    Public Sub New(ByVal givenSuit As String, ByVal givenRank As String, ByVal givenValue As Integer)
        suit = givenSuit
        rank = givenRank
        value = givenValue
    End Sub
End Class


Class Player

    Private name As String
    Private score As Integer

    ' Constructor method
    Public Sub New(ByVal givenName As String)
        name = givenName
        score = 0
    End Sub

End Class


Module Program

    ' The Main method is the default entry point for all VB programs
    Sub Main()
        ' Instantiate a new player object
        Console.WriteLine("Enter your name: ")
        Dim playerName As String = Console.ReadLine()
        Dim gamePlayer As Player = New Player(playerName)
    End Sub


End Module
