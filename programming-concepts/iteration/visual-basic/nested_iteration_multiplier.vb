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
        Dim result As Integer

        For num As Integer = 1 To 3

            For multiplier As Integer = 1 To 10
                result = num * multiplier
                Console.WriteLine($"{num} * {multiplier} = {result}")
            Next
        Next
    End Sub

End Module