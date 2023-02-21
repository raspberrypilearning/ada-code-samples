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
        Dim fileName As String = "monster.csv"
        Dim extension As String = GetExtension(fileName)
        Console.WriteLine(extension)
    End Sub

    Function GetExtension(ByVal fileName As String) As String
        Dim position As Integer = fileName.IndexOf(".")
        Dim index As Integer = position + 1
        Dim extension As String = fileName.Substring(index)
        Return extension
    End Function


End Module
