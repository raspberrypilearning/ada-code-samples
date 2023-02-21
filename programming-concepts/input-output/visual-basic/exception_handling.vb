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
        Console.WriteLine("Enter a number")
        Try
            Dim userInput As String = Console.ReadLine()
            Dim numValue As Integer = Int32.Parse(userInput)
        Catch ex As FormatException
            Console.WriteLine("You must enter a numeric value")
        End Try
    End Sub

End Module
