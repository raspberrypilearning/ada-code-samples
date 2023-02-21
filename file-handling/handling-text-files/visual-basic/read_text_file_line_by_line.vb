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
        ReadLineByLine()
    End Sub

    Sub ReadLineByLine()
         Using reader As System.IO.StreamReader = New System.IO.StreamReader("bridge.txt")
             Dim line As String
             line = reader.ReadLine()
             While line IsNot Nothing ' While not end of file
                Console.WriteLine(line) 
                line = reader.ReadLine() ' Read next ine of file
             End While
         End Using
     End Sub


End Module
