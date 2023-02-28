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

    ' The Main subroutine is the default entry point for a VB program
    Sub Main()
        ShowSubstrings()
    End Sub

    Sub ShowSubstrings()
        Dim myString As String = "Computer Science"
        ' Display characters 7 To 9 ("r S")
        Console.WriteLine(myString.Substring(7, 3))
        ' Display 5 characters from start of string ("Compu")
        Console.WriteLine(Left(myString, 5))
        ' Display the last 10 characters of the string ("er Science")
        Console.WriteLine(Right(myString, 10))
    End Sub


End Module
