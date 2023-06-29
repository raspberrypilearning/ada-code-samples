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
        ' Declare and initialise the array of words
        Dim spellingWords = New String(4) {"me", "do", "her", "it", "him"}

        ' Output the spelling words array
        DisplayWords(spellingWords)
    End Sub


    ' Display the words from the given spelling list
    Sub DisplayWords(ByVal spellingWords As String())
        Console.WriteLine("Spelling words:")

        ' Repeat for each value in the array
        For Each word In spellingWords
            Console.WriteLine(word)
        Next
    End Sub


End Module
