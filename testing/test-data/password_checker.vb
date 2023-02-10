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
        Dim passwordToCheck As String = "test"
        Dim result As Boolean = CheckPassword(passwordToCheck)
        Console.WriteLine(result)

    End Sub

    Function CheckPassword(ByVal password As String) As Boolean
        Dim isValid As Boolean = True

        If password.Length < 8 OrElse password.Length > 14 Then
            isValid = False
        End If

        Return isValid
    End Function



End Module
