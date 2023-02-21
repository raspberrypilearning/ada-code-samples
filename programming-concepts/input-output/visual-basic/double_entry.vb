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
        Console.WriteLine("Enter your email address: ")
        Dim email As String = Console.ReadLine()
        Console.WriteLine("Re-type your email address: ")
        Dim verifyEmail As String = Console.ReadLine()

        If email = verifyEmail Then
            Console.WriteLine("The emails match")
        Else
            Console.WriteLine("Error: the email addresses did not match")
        End If
    End Sub

End Module
