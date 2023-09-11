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

    ' The Main subroutine is the entry point for all VB programs

    Sub Main()
        ' Declare and initialise the two-dimensional array of words
        Dim spellingWords = New String(2, 4) {
                {"me", "do", "it", "her", "him"},
                {"put", "ask", "says", "red", "any"},
                {"they", "where", "friend", "fast", "class"}
        }

        ' Output every word in the array
        Console.WriteLine("Display each word along with the level:")
        DisplayAllWords(spellingWords)
    End Sub


    ' Display the words of each level in the 2D array
    Sub DisplayAllWords(ByVal spellingWords As String(,))

        ' Repeat for each level
        Dim numLevels = spellingWords.GetLength(0)
        For i = 0 To numLevels - 1
            Dim levelNum = i + 1  ' Level index starts from 0
            Console.WriteLine($"Level {levelNum}:")

            ' Output each word for the current level
            Dim numWords = spellingWords.GetLength(1)
            For j = 0 To numWords - 1
                Console.WriteLine(spellingWords(i, j))
            Next
        Next
    End Sub


End Module
