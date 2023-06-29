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
        ' Declare and initialise the three-dimensional array of words
        Dim spellingWords = New String(1, 2, 4) {
            {
                {"me", "do", "her", "it", "him"},
                {"put", "ask", "says", "red", "any"},
                {"they", "where", "friend", "fast", "class"}
            },
            {
                {"door", "find", "most", "bath", "eye"},
                {"every", "great", "climb", "prove", "behind"},
                {"clothes", "again", "improve", "should", "parents"}
            }
        }


        ' Output every word in the array
        Console.WriteLine("Display every word in the spelling words array:")
        DisplayAllWords(spellingWords)
    End Sub


    ' Display the words of each year and level in the 3D array
    Sub DisplayAllWords(ByVal spellingWords As String(,,))

        ' Output each word for each year and level
        For Each word In spellingWords
            Console.WriteLine(word)
        Next
    End Sub


End Module
