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
        Console.WriteLine("Enter a string to check if it is empty:")
        Dim userInput As String = Console.ReadLine()
        Dim isEmpty As Boolean = CheckEmptyString(userInput)

        If isEmpty = True Then
            Console.WriteLine("Yes, the string is empty!")
        Else
            Console.WriteLine("No, the string is not empty!")
        End If
    End Sub

    Function CheckEmptyString(ByVal myString As String) As Boolean
        Dim empty As Boolean = False

        If String.IsNullOrEmpty(myString) Then
            empty = True
        End If

        Return empty
    End Function


End Module
