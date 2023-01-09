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
        Dim num As Integer = 5 ' Test data
        Dim result As Integer = SumTo(num)
        Console.WriteLine($"The sum of all integers from 1 to {num} is {result}")
        Console.ReadLine()
    End Sub

    Function SumTo(ByVal givenNumber As Integer) As Integer
        Dim total As Integer = 0

        For i As Integer = 1 To givenNumber
            total = total + i
        Next

        Return total
    End Function

End Module

