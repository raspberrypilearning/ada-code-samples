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
        Dim rainbow As String() = {"red", "orange", "yellow", "green", "blue", "indigo", "violet"}

        For Each colour As String In rainbow
            Console.WriteLine(colour)
        Next
    End Sub

End Module
