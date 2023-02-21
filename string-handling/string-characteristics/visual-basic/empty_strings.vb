' Raspberry Pi Foundation
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
        DemonstrateEmptyStrings()
    End Sub

    Sub DemonstrateEmptyStrings()
        Dim emptyString As String = ""
        Console.WriteLine(emptyString.Length)

        Dim stringWithSpace As String = " "
        Console.WriteLine(stringWithSpace.Length)

        If emptyString = stringWithSpace Then
            Console.WriteLine("We are the same")
        Else
            Console.WriteLine("We are different")
        End If
    End Sub


End Module
