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
        Dim x As Integer = 259 ' Test data
        Dim y As Integer = 111 ' Test data
        Dim answer As Integer = GCD(x, y)
        Dim output As String = $"The lowest common denominator of {x} and {y} is {answer}"
        Console.WriteLine(output)
        Console.ReadLine()
    End Sub

    Function GCD(ByVal x As Integer, ByVal y As Integer) As Integer
        If y = 0 Then
            Return x
        Else
            Return GCD(y, x Mod y)
        End If
    End Function

End Module
