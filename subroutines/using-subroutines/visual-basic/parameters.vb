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
        Console.WriteLine("Enter a number: ")
        Dim userResponse As String = Console.ReadLine()
        Dim number1 As Integer = Int32.Parse(userResponse)  // Convert input value to integer
        Console.WriteLine("Enter another number: ")
        userResponse = Console.ReadLine()
        Dim number2 As Integer = Int32.Parse(userResponse)
        CalculateSum(number1, number2)  // Calls CalculateSum
    End Sub

    Sub CalculateSum(ByVal number1 As Integer, ByVal number2 As Integer)
        Dim answer As Integer = number1 + number2
        Console.WriteLine($"The sum of {number1} and {number2} is {answer}")
    End Sub


End Module
