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
        Console.Write("What is your name? ")
        Dim name As String = Console.ReadLine()
        Console.WriteLine("Greetings " & name)
        RunQuiz()
        Console.WriteLine("End of the quiz")
    End Sub

    Sub RunQuiz()
        Console.WriteLine("What is the capital city of Botswana?")
        Dim answer As String = Console.ReadLine()

        If answer = "Gaborone" Then
            Console.WriteLine("Well done!")
        Else
            Console.WriteLine("Sorry! That is the wrong answer")
        End If
    End Sub


End Module
