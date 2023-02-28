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

    ' The Main subroutine is the default entry point for a VB program
    Sub Main()
        Dim sum As Integer = 0
        Dim numValues As Integer = 0

        Console.WriteLine("Enter a mark or -1 to end ")
        Dim userInput As String = Console.ReadLine()
        Dim mark As Integer = Int32.Parse(userInput)

        While mark <> -1
            sum = sum + mark
            numValues = numValues + 1
            Console.WriteLine("Enter a mark or -1 to end ")
            userInput = Console.ReadLine()
            mark = Int32.Parse(userInput)
        End While

        Dim average As Double = CDbl(sum) / CDbl(numValues)
        Console.WriteLine($"The average mark was {average}")
    End Sub

End Module
