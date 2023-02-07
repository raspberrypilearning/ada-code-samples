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
        Dim n As Integer = 6
        Dim result As Integer = SumToN(n)
        Dim output As String = $"The sum of 1 to {n.ToString()} is: {result.ToString()}"
        Console.WriteLine(output)
        Console.ReadLine()
    End Sub

    Function SumToN(ByVal n As Integer) As Integer
        Dim total As Integer = 0

        For i As Integer = 1 To n
            total = total + i
        Next

        Return total
    End Function

End Module
