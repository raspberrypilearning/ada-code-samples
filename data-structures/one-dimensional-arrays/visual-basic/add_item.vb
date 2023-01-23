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
        Dim emotions(5) As String  'Declare empty array with 6 elements
        emotions(0) = "amazed"
        emotions(1) = "delighted"
        emotions(2) = "ecstatic"
        emotions(3) = "enthusiastic"
        emotions(4) = "lively"
        emotions(5) = "happy"
        Console.WriteLine(emotions(2)) 'Display third item in the array
    End Sub
End Module