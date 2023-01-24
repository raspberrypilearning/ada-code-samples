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
        Console.WriteLine("Enter hours worked ")
        Dim hoursInput As String = Console.ReadLine()
        Dim hours As Double = Convert.ToDouble(hoursInput)
        Console.WriteLine("Enter hourly rate ")
        Dim rateInput As String = Console.ReadLine()
        Dim rate As Double = Convert.ToDouble(rateInput)
        Dim pay As Double = CalculatePay(hours, rate)
        Console.WriteLine($"Pay is £{pay}")
    End Sub

    Function CalculatePay(ByVal h As Double, ByVal r As Double) As Double
        Dim pay As Double = h * r
        Return pay
    End Function


End Module
