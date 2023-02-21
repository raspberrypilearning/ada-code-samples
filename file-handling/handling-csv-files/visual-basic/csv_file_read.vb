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
        ReadCsv()
    End Sub

    Sub ReadCsv()
        Dim fileName As String = "movies.csv"
        Using reader As System.IO.StreamReader = New IO.StreamReader(fileName)
            Dim record As String
            record = reader.ReadLine()

            While record IsNot Nothing
                Dim movieData As String() = record.Split(",")
                Dim title As String = movieData(0)
                Dim rating As String = movieData(4)
                Console.WriteLine($"Movie name: {title}, Rating: {rating}")
                record = reader.ReadLine()
            End While
        End Using
    End Sub


End Module
