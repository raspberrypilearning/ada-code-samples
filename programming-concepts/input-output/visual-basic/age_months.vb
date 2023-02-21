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
        Console.WriteLine("How old are you?")
        Dim user_response As String = Console.ReadLine()
        Dim age As Integer = Int32.Parse(user_response)
        Dim months As Integer = age * 12
        Console.WriteLine($"Wow, you have been alive for around {months} months!")
    End Sub

End Module
