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
        Dim difficulty As String = "Hard"
        Dim score As Integer = 55
        Dim gameOver As Boolean = False

        If Not gameOver Then

            If difficulty = "Hard" AndAlso score > 60 Then
                Console.WriteLine("Wow, you are doing great!")
            ElseIf (difficulty = "Normal" OrElse difficulty = "Easy") AndAlso score > 40 Then
                Console.WriteLine("Good stuff, keep it up!")
            Else
                Console.WriteLine("Keep going!")
            End If
        End If
    End Sub

End Module
