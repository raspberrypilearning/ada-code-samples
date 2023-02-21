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
        Dim numbersToGuess As Integer() = {1, 4, 8, 3, 10}
        Console.WriteLine("Guess my numbers, each number is between 1 and 10")

        For Each number As Integer In numbersToGuess
            Console.WriteLine("Enter a number to guess: ")
            Dim userInput As String = Console.ReadLine()
            Dim guess As Integer = Int32.Parse(userInput)

            While guess <> number
                Console.WriteLine("Incorrect number. Try again: ")
                userInput = Console.ReadLine()
                guess = Int32.Parse(userInput)
            End While

            Console.WriteLine("Well done, next number to guess")
        Next
    End Sub

End Module
