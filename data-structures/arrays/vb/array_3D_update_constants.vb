' Raspberry Pi Foundation
' Developed as part of Ada Computer Science
' Usage licensed under CC BY-NC-SA 4.0
' Note: This file is designed to be copied out and compiled on your machine.
' To run this file you need to:
' 1. Copy the contents
' 2. Paste them into the Visual Basic IDE of your choice (Visual Studio, for example)
' 3. Compile the program
' 4. Run the program


Module Program

    ' Constants to store index values of each year
    Public Const Year1 As Integer = 0
    Public Const Year2 As Integer = 1

    ' Constants to store index values of each level
    Public Const Level1 As Integer = 0
    Public Const Level2 As Integer = 1
    Public Const Level3 As Integer = 2


    ' The Main subroutine is the entry point for all VB programs
    Sub Main()
        ' Declare and initialise the three-dimensional array of words
        Dim spellingWords = New String(1, 2, 4) {
            {
                {"me", "do", "it", "her", "him"},
                {"put", "ask", "says", "red", "any"},
                {"they", "where", "friend", "fast", "class"}
            },
            {
                {"door", "find", "most", "bath", "eye"},
                {"every", "great", "climb", "prove", "behind"},
                {"clothes", "again", "improve", "should", "parents"}
            }
        }


        ' Ask the user for the new word
        Console.WriteLine("Enter the new word:")
        Dim newWord As String = Console.ReadLine()

        ' Store the original word for Year 1, Level 3 at index 4
        Dim wordIndex = 4
        Dim oldWord = spellingWords(Year1, Level3, wordIndex)

        ' Update the word for Year 1, Level 3 at index 4
        spellingWords(Year1, Level3, wordIndex) = newWord

        ' Output the updated word
        Dim updatedWord = spellingWords(Year1, Level3, wordIndex)
        Console.WriteLine($"The word {oldWord} has been updated to {updatedWord}")
    End Sub


End Module
