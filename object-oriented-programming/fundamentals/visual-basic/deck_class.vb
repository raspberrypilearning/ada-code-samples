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


Class Deck

    Private cards As PlayingCard() = New PlayingCard(51) {} ' Declare an array of 52 elements
    Private suits As String() = {"Clubs", "Diamonds", "Hearts", "Spades"}
    Private ranks As String() = {"Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King"}
    Private values As Integer() = {11, 2, 3, 4, 5, 6, 7, 8, 9, 10, 10, 10, 10}

    ' Constructor method
    Public Sub New()
        Dim cardNumber As Integer = 0

        ' Repeat for all 4 suits
        For i As Integer = 0 To suits.Length - 1
            ' Repeat for all 13 ranks of a suit
            For j As Integer = 0 To ranks.Length - 1
                Dim newCard As PlayingCard = New PlayingCard(suits(i), ranks(j), values(j))
                cards(cardNumber) = newCard
                cardNumber += 1
            Next
        Next

        ' Show that all 52 playing cards have been initialised
        Console.WriteLine($"Initialised {cardNumber} playing cards")
    End Sub

End Class


Module Program

    ' The Main method is the default entry point for all VB programs
    Sub Main()
        ' Instantiate a new deck object
        Dim myDeck As Deck = New Deck()
    End Sub

End Module
