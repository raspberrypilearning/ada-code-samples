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
    ' The Main subroutine is the entry point for all VB programs
    Sub Main()
        ' Declare and initialise the astronaut dictionary
        Dim astronaut = New Dictionary(Of String, String)() From {
            {"craft", "ISS"},
            {"name", "Sultan Al Neyadi"},
            {"days", "14"},
            {"country", "United Arab Emirates"}
        }

        ' Ask the user for a key to find
        Console.WriteLine("Enter a key to find:")
        Dim inputKey As String = Console.ReadLine()

        ' Check if the key exists in the dictionary
        If astronaut.ContainsKey(inputKey) Then
            Console.WriteLine("Key exists!")
            Dim value = astronaut(inputKey)
            Console.WriteLine($"Key: {inputKey}, value: {value}")
        Else
            Console.WriteLine("That key does not exist")
        End If
    End Sub


End Module
