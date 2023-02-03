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
        Dim amount As Double = 130.4
        Dim result As Double = AddVat(amount)
        Console.WriteLine(result)
    End Sub

    Function AddVat(ByVal amount As Double) As Double
        ' Demonstrates a logic error
        Dim RATE As Integer = 20
        Dim vat As Double = amount * RATE
        Dim withVat As Double = amount + vat
        Return withVat
    End Function

End Module
