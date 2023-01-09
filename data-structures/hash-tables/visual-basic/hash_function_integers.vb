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
        Dim key As Integer = 12345
        Dim slots As Integer = 97
        Dim value As Integer = HashInteger(key, slots)
        Console.WriteLine($"Hash value for {key} is {value}")
    End Sub

    Function HashInteger(ByVal hashKey As Integer, ByVal numberOfSlots As Integer) As Integer
        Dim hashValue As Integer = hashKey Mod numberOfSlots
        Return hashValue
    End Function

End Module

