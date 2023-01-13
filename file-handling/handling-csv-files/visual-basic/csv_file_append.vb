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
        AppendMovie()
    End Sub

    Sub AppendMovie()
        Dim filename As String = "movies.csv"
        Dim newMovie As String = "CODA,2021,111,Sian Heder,8.1,1.5"

        Using writer As System.IO.StreamWriter = New System.IO.StreamWriter(filename, True)
            writer.WriteLine(newMovie)
        End Using
    End Sub


End Module
