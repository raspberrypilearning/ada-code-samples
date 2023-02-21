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
        WriteToFile()
    End Sub

    Sub WriteToFile()
        Using writer As System.IO.StreamWriter = New System.IO.StreamWriter("twinkle.txt", False)
            writer.WriteLine("Twinkle, twinkle, little star,")
            writer.WriteLine("How I wonder what you are!")
            writer.WriteLine("Up above the world so high,")
            writer.WriteLine("Like a diamond in the sky.")
        End Using
    End Sub


End Module
