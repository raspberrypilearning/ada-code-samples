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
        Dim amount As Integer = 100
        Console.WriteLine($"Amount at start of main function is: {amount}")
        Triple(amount)
        Quadruple(amount)
        Console.WriteLine($"Amount at end of main function is: {amount}")
    End Sub

    Sub Triple(ByVal n As Integer)
        Dim amount As Integer = n * 3
        Console.WriteLine($"Amount (in Triple) is: {amount}")
    End Sub

    Sub Quadruple(ByVal n As Integer)
        Dim amount As Integer = n * 4
        Console.WriteLine($"Amount (in Quadruple) is: {amount}")
    End Sub


End Module
