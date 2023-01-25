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
        Console.WriteLine("What hour is it?")
        Dim user_input As String = Console.ReadLine()
        Dim hour As Integer = Int32.Parse(user_input)

        If hour < 12 Then
            Console.WriteLine("Good morning")
        ElseIf hour < 18 Then
            Console.WriteLine("Good afternoon")
        ElseIf hour < 22 Then
            Console.WriteLine("Good evening")
        Else
            Console.WriteLine("Good night")
        End If
    End Sub

End Module
