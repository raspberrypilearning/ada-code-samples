' Raspberry Pi Foundation
' Developed as part of Ada Computer Science
' Usage licensed under CC BY-NC-SA 4.0
' Note: This file is designed to be copied out and compiled on your machine.
' To run this file you need to:
' 1. Copy the contents
' 2. Paste them into the Visual Basic IDE of your choice (Visual Studio, for example)
' 3. Compile the program
' 4. Run the program


Module program


    Const LEVEL1 As Integer = 0
    Const LEVEL2 As Integer = 1
    Const LEVEL3 As Integer = 2


    ' The Main method is the default entry point for all VB programs
    Sub Main()
        Dim spellingWords(2, 2) As String ' Declare a two dimensional array

        spellingWords(0, 0) = "school"
        spellingWords(0, 1) = "pull"
        spellingWords(0, 2) = "where"
        spellingWords(1, 0) = "path"
        spellingWords(1, 1) = "floor"
        spellingWords(1, 2) = "sugar"
        spellingWords(2, 0) = "accident"
        spellingWords(2, 1) = "answer"
        spellingWords(2, 2) = "eight"

        ' Display all of the level 2 words
        For word = 0 To 2
            Console.WriteLine(spellingWords(LEVEL2, word))
        Next

    End Sub


End Module
