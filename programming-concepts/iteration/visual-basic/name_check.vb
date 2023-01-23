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
        Console.WriteLine("Please enter your name: ")
        Dim name As String = Console.ReadLine()

        While name <> "Bob"
            Console.WriteLine("Try again Bob")
            Console.WriteLine("Please enter your name: ")
            name = Console.ReadLine()
        End While

        Console.WriteLine("Hi Bob")
    End Sub

End Module
