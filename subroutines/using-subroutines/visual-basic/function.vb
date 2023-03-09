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
        Dim result As Integer = AddTwoNumbers(5, 10)
        Console.WriteLine(result)
    End Sub

    Function AddTwoNumbers(ByVal number1 As Integer, ByVal number2 As Integer)
        Dim answer As Integer = number1 + number2
        return answer
    End Function


End Module
