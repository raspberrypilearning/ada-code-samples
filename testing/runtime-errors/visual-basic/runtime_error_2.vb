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
      ' Demonstrates a runtime error
      Dim file As String = "highscores.txt"
      Dim contents As String() = File.ReadAllLines(file)
      Console.WriteLine(contents)
    End Sub


End Module
