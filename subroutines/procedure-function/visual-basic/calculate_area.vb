' Raspberry Pi Foundation
' Developed as part of Ada Computer Science
' Usage licensed under CC BY-NC-SA 4.0
' Note: This file is designed to be copied out and compiled on your machine.
' To run this file you need to:
' 1. Copy the contents
' 2. Paste them into the Visual Basic IDE of your choice (Visual Studio, for example)
' 3. Compile the program
' 4. Run the program


Module Program

    ' The Main subroutine is the default entry point for all VB programs
    Sub Main()
        Dim length As Single = 12
        Dim result = CalculateArea(length)
        Console.WriteLine(result)
    End Sub


    ' Calculates the area of a square with sides of a given length
    Function CalculateArea(ByVal length As Single) As Single
        Dim area = length * length
        Return area
    End Function


End Module
