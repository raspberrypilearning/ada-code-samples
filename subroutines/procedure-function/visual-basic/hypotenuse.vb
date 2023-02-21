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
        Dim side1 As Double = 3
        Dim side2 As Double = 4
        Dim hypotenuse As Double = GetHypotenuse(side1, side2)
        Console.WriteLine($"The hypotenuse is: {hypotenuse}")
    End Sub

    Function GetHypotenuse(ByVal a As Double, ByVal b As Double) As Double
        Dim h As Double = Math.Sqrt(CalculateArea(a) + CalculateArea(b))
        Return h
    End Function

    Function CalculateArea(ByVal length As Double) As Double
        Dim area As Double = length * length
        Return area
    End Function


End Module
