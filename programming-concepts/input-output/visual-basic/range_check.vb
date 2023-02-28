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
        Console.WriteLine("Enter a week of the year: ")
        Dim userInput As String = Console.ReadLine()
        Dim week As Integer = Int32.Parse(userInput)

        If week >= 1 AndAlso week <= 52 Then
            Console.WriteLine($"You have chosen week {week}")
        Else
            Console.WriteLine("A week must be between 1-52")
        End If
    End Sub

End Module
