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
        RentCheck()
    End Sub

    Sub RentCheck()
        Console.WriteLine("Enter your age: ")
        Dim inputAge As String = Console.ReadLine()
        Dim age As Integer = Int32.Parse(inputAge)

        If age >= 21 Then
            Console.WriteLine("Enter your salary: ")
            Dim inputSalary As String = Console.ReadLine()
            Dim salary As Integer = Int32.Parse(inputSalary)
            If salary > 15000 Then
                Console.WriteLine("You can rent the flat")
            Else
                Console.WriteLine("You don't earn enough to rent the flat")
            End If
        ElseIf age >= 18 AndAlso age < 21 Then
            Console.WriteLine("Do you have a guarantor (yes/no): ")
            Dim guarantor As String = Console.ReadLine()
            If guarantor = "yes" Then
                Console.WriteLine("We will need to contact your guarantor")
            Else
                Console.WriteLine("I am sorry but you need a guarantor")
            End If
        Else
            Console.WriteLine("I am sorry but you can't rent the flat")
        End If
    End Sub

End Module
