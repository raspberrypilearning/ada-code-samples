' Raspberry Pi Foundation
' Developed as part of Ada Computer Science
' Usage licensed under CC BY-NC-SA 4.0
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


    Public Function GetSuit() As String
        Return suit
    End Function


    Public Function GetRank() As String
        Return rank
    End Function


    Public Function GetValue() As Integer
        Return value
    End Function


End Class


Module Program

    ' The Main method is the default entry point for all VB programs
    Sub Main()
        ' Instantiate a new card object
        Dim myCard As PlayingCard = New PlayingCard("clubs", "2", 2)
        Console.WriteLine($"Suit is: {myCard.GetSuit()}")
        Console.WriteLine($"Rank is: {myCard.GetRank()}")
        Console.WriteLine($"Value is: {myCard.GetValue()}")
    End Sub


End Module
