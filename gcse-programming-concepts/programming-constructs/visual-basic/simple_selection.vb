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
        Console.WriteLine("Which animal has a long bendy trunk?")
        Dim animal As String = Console.ReadLine()

        If animal = "Elephant" Then
            Console.WriteLine("You are correct")
        Else
            Console.WriteLine("You are incorrect")
        End If
    End Sub


End Module
