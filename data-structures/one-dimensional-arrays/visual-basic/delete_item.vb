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
        Dim emotions(5) As String
        emotions(0) = "amazed"
        emotions(1) = "delighted"
        emotions(2) = "ecstatic"
        emotions(3) = "enthusiastic"
        emotions(4) = "lively"
        emotions(5) = "happy"

        emotions(2) = ""  'Deletes the item in the third slot Of the array
    End Sub
End Module