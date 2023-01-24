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
        Console.WriteLine("Please enter a number")
        Dim num1String As String = Console.ReadLine()
        Dim num1 As Integer = Convert.ToInt32(num1String)
        Console.WriteLine("Please enter another number")
        Dim num2String As String = Console.ReadLine()
        Dim num2 As Integer = Convert.ToInt32(num2String)
        CalculateProduct(num1, num2)
    End Sub

    Sub CalculateProduct(ByVal n1 As Integer, ByVal n2 As Integer)
        Dim product As Integer = n1 * n2
        Console.WriteLine($"The product of the two numbers is {product}")
    End Sub


End Module
