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
        SelectHighEarners()
    End Sub

    Sub SelectHighEarners()
        Dim fileName As String = "movies.csv"
        Dim highEarners As Integer = 0

        Using reader As System.IO.StreamReader = New System.IO.StreamReader(fileName)
            Dim record As String
            record = reader.ReadLine()

            While record IsNot Nothing
                Dim movieData As String() = record.Split(",")
                Dim revenue As Decimal = Decimal.Parse(movieData(5))
                If revenue > 200 Then
                    Dim title As String = movieData(0)
                    Console.WriteLine($"Movie name: {title}, Revenue: ${revenue} million")
                    highEarners = highEarners + 1
                End If
                record = reader.ReadLine()  'Read next record
            End While
        End Using

        Console.WriteLine($"There were {highEarners} high earning movies.")
    End Sub


End Module
