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
        Dim cold As Boolean = True
        Dim wet As Boolean = False

        If Not (cold AndAlso wet) Then
            Console.WriteLine("It's OK to go outside")
        Else
            Console.WriteLine("I'm going to stay inside")
        End If
    End Sub

End Module
