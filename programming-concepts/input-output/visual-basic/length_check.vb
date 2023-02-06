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
        Dim validLength As Boolean = False
        Console.WriteLine("Enter your booking reference: ")
        Dim booking As String = Console.ReadLine()

        If booking.Length = 8 Then
            validLength = True
        End If

        Console.WriteLine(validLength)
    End Sub

End Module
