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
        Dim letter As Char = "B"
        Dim lowerCase As Char = ConvertToLower(letter)
        Console.WriteLine(lowerCase)
    End Sub

    Function ConvertToLower(ByVal letter As Char) As Char
        Dim letterCode As Integer = Asc(letter)
        Dim newLetterCode As Integer = letterCode + 32
        Dim lowerCase As Char = Convert.ToChar(newLetterCode)
        Return lowerCase
    End Function


End Module
