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
        PrintBackwards("I am a computer scientist") ' Test data
        Console.ReadLine()
    End Sub

    Sub PrintBackwards(ByVal phrase As String)
        If phrase.Length = 1 Then
            Console.Write(phrase)
        Else
            Dim newPhrase As String = phrase.Substring(1, phrase.Length - 1)
            PrintBackwards(newPhrase)
            Console.Write(phrase.Substring(0, 1))
        End If
    End Sub

End Module

