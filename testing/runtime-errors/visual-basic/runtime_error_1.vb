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
        ' Demonstrates a runtime error when entering a string value
        Console.WriteLine("Please enter a number:")
        Dim numberString As String = Console.ReadLine()
        Dim number As Integer = Int32.Parse(numberString)
        Console.WriteLine(number)
    End Sub

End Module
