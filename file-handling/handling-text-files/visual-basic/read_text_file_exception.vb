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
        ReadFileWithExceptionHandler()
    End Sub

    Sub ReadFileWithExceptionHandler()
        Dim fileName As String = "twynkle.txt"
        Try
            Using reader As System.IO.StreamReader = New System.IO.StreamReader(fileName)
                Dim line As String
                line = reader.ReadLine()
                Do Until line Is Nothing
                    Console.WriteLine(line)
                    line = reader.ReadLine()
                Loop
            End Using
        Catch ex As Exception
            Console.WriteLine($"{fileName} could not be found")
        End Try
    End Sub


End Module
