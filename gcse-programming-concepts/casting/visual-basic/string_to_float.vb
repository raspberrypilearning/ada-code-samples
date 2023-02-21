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
        DoubleIt()
    End Sub

    Sub DoubleIt()
        Console.WriteLine("Enter a number ")
        Dim number As String = Console.ReadLine()
        Dim floatNumber As Single = Single.Parse(number)
        Dim answer As Single = floatNumber * 2.0F
        Console.WriteLine(answer)
    End Sub


End Module
