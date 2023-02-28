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
        Console.Write("Enter height: ")
        Dim inputHeight As String = Console.ReadLine()
        Dim height As Single = Single.Parse(inputHeight)
        Console.Write("Enter width: ")
        Dim inputWidth As String = Console.ReadLine()
        Dim width As Single = Single.Parse(inputWidth)
        Console.Write("Enter depth: ")
        Dim inputDepth As String = Console.ReadLine()
        Dim depth As Single = Single.Parse(inputDepth)
        Dim volume As Single = CalculateVolume(height, width, depth)
        Console.Write($"Volume is: {volume}")
    End Sub

    Function CalculateVolume(ByVal height As Single, ByVal width As Single, ByVal depth As Single) As Single
        Dim volume As Single = height * width * depth
        Return volume
    End Function


End Module
