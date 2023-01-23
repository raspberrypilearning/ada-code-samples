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
        ShowError()
    End Sub

    Sub ShowError()
        Console.WriteLine("Enter the error code: ")
        Dim errorCode As String = Console.ReadLine()

        If errorCode = "400" Then
            Console.WriteLine("Bad request")
        ElseIf errorCode = "401" Then
            Console.WriteLine("Unauthorised request")
        ElseIf errorCode = "403" Then
            Console.WriteLine("Forbidden request")
        ElseIf errorCode = "404" Then
            Console.WriteLine("Page not found")
        ElseIf errorCode = "408" Then
            Console.WriteLine("Timeout error")
        Else
            Console.WriteLine("Unknown error")
            End If
    End Sub

End Module
