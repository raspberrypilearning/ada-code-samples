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
        Dim n As Integer = 5 ' Test data
        Dim result As Integer = Factorial(n)
        Dim output As String = $"{n}! is: {result}"
        Console.WriteLine(output)
        Console.ReadLine()
    End Sub

    Function Factorial(ByVal n As Integer) As Integer
        If n = 1 Then
            Return 1
        Else
            Return n * Factorial(n - 1)
        End If
    End Function

End Module

