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
        CalculateTwoNumbers(5, 10)
    End Sub

    Sub CalculateTwoNumbers(ByVal number1 As Integer, ByVal number2 As Integer)
        Dim answer As Integer = number1 + number2
        Console.WriteLine($"The sum of {number1} and {number2} is {answer}")
    End Sub


End Module
