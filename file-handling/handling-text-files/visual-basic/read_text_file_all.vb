' Raspberry Pi Foundation
' Developed as part of Ada Computer Science
' Usage licensed under CC BY-NC-SA 4.0
' Note: This file is designed to be copied out and compiled on your machine.
' To run this file you need to:
' 1. Copy the contents
' 2. Paste them into the Visual Basic IDE of your choice (Visual Studio, for example)
' 3. Compile the program
' 4. Run the program (make sure the text file is in the same folder)

Module Program

    ' The Main subroutine is the default entry point for a VB program
    Sub Main()
        ReadAll()
    End Sub

    Sub ReadAll()
        Dim rhyme As String

        Using reader As System.IO.StreamReader = New System.IO.StreamReader("bridge.txt")
            rhyme = reader.ReadToEnd()
        End Using

        Console.WriteLine(rhyme)
    End Sub

End Module
