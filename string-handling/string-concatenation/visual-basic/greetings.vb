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
        GreetUser()
    End Sub

    Sub GreetUser()
        Console.Write("Please enter your first name ")
        Dim firstName As String = Console.ReadLine()
        Console.WriteLine("Greetings " & firstName)
        Console.Write("Please enter your last name ")
        Dim lastName As String = Console.ReadLine()
        Dim userName As String = firstName & " " & lastName
        Console.WriteLine("Greetings " & userName)
    End Sub


End Module
