' Raspberry Pi Foundation
' Usage licensed under CC BY-SA 4
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
        Console.WriteLine(myString.Substring(0, 5))
        ' Display characters from index position 6 to end of string ("er Science")
        Console.WriteLine(myString.Substring(6))
    End Sub


End Module
