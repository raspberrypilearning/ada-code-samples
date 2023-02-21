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
        AppendToFile()
    End Sub

    Sub AppendToFile()
        Using writer As System.IO.StreamWriter = New System.IO.StreamWriter("twinkle.txt", True)
            writer.WriteLine("")
            writer.WriteLine("When the blazing sun is gone")
            writer.WriteLine("When he nothing shines upon,")
            writer.WriteLine("Then you show your little light,")
            writer.WriteLine("Twinkle, twinkle, all the night.")
        End Using
    End Sub


End Module
