' Raspberry Pi Foundation
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

End Class


Module Program

    ' The Main method is the default entry point for all VB programs
    Sub Main()
        ' Instantiate a new card object
        Dim myCard As PlayingCard = New PlayingCard("clubs", "2", 2)
            
        ' Show that the card object has been created
        Console.WriteLine(myCard);
    End Sub


End Module
