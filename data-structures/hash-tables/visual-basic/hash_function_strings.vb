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
        Dim key As String = "A5RD" ' Test data
        Dim slots As Integer = 97 ' Test data
        Dim value As Integer = HashString(key, slots)
        Console.WriteLine($"Hash value for {key} is {value}")
    End Sub

    Function HashString(ByVal hashKey As String, ByVal numberOfSlots As Integer) As Integer
        Dim total As Integer = 0
        
        ' For each character in the hash key
        For i As Integer = 0 To hashKey.Length - 1
            'Get the ASCII code for the character
            Dim asciiCode As Integer = Asc(hashKey(i))
            ' Add the value of the code to the total
            total = total + asciiCode
        Next

    ' Calculate the hash value using the modulo operator
        Dim hashValue As Integer = total Mod numberOfSlots
        Return hashValue
    End Function

End Module
