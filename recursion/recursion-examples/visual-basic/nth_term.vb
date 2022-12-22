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
        Dim n As Integer = 6 ' Test data
        Dim increment As Integer = 3 ' Test data
        Dim result As Integer = NthTerm(n, increment)
        Console.WriteLine($"Term {n} is {result}")
        Console.ReadLine()
    End Sub

    Function NthTerm(ByVal n As Integer, ByVal increment As Integer) As Integer
        If n = 1 Then ' Base case
            Return 1
        Else
            Return increment + NthTerm(n - 1, increment) ' General case
        End If
    End Function

End Module

