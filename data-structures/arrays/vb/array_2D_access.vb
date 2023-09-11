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

        ' Output the word for Level 3 at index 4
        Dim word = spellingWords(2, 4)
        Console.WriteLine($"The word for Level 3 at index 4 is {word}")
    End Sub


End Module
