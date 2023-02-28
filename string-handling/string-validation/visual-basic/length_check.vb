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
        Dim password As String = "elephant1234"
        Dim result As Boolean = CheckPassword(password)
        Console.WriteLine($"{password} is valid: {result}")
        password = "elephant"
        result = CheckPassword(password)
        Console.WriteLine($"{password} is valid: {result}")
        password = "1234"
        result = CheckPassword(password)
        Console.WriteLine($"{password} is valid: {result}")
    End Sub

    Function CheckPassword(ByVal password As String) As Boolean
        Dim isValid As Boolean = True

        If password.Length < 8 Then
            isValid = False
        End If

        Return isValid
    End Function


End Module
