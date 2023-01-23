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

        Select Case errorCode
            Case "400"
                Console.WriteLine("Bad request")
            Case "401"
                Console.WriteLine("Unauthorised request")
            Case "403"
                Console.WriteLine("Forbidden request")
            Case "404"
                Console.WriteLine("Page not found")
            Case "408"
                Console.WriteLine("Timeout error")
            Case Else
                Console.WriteLine("Unknown error")
        End Select
    End Sub

End Module
