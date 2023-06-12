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
        Dim astronaut As Dictionary(Of String, String) = New Dictionary(Of String, String)() From {
            {"craft", "ISS"},
            {"name", "Sultan Al Neyadi"},
            {"days", "14"}
        }

        ' Ask the user for the country of origin
        Console.WriteLine("Enter the astronaut's country:")
        Dim inputCountry As String = Console.ReadLine()

        ' Add the country key-value pair to the dictionary
        astronaut("country") = inputCountry

        ' Output the country of origin
        Dim newCountry = astronaut("country")
        Console.WriteLine($"The country {newCountry} has been added")
    End Sub

End Module
