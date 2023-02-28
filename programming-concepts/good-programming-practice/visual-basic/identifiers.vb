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

    Const GravityOnEarth As Double = 9.81
    Const GravityOnMars As Double = 3.711

    ' The Main subroutine is the default entry point for a VB program
    Sub Main()
        Dim weight As Double = 35.7
        Console.WriteLine(Conv(weight))
        Console.WriteLine(CalculateWeightOnMars(weight))
    End Sub

    ' First example
    Function Conv(ByVal a As Double) As Double
        Dim b As Double = a / 9.81 * 3.711
        Return b
    End Function

    ' Second example
    ' Convert a weight on Earth to the weight on Mars based on gravity
    Function CalculateWeightOnMars(ByVal weightOnEarth As Double) As Double
        Dim weightOnMars As Double = weightOnEarth / GravityOnEarth * GravityOnMars
        Return weightOnMars
    End Function

End Module
