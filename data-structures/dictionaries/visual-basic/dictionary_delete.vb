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
            {"days", "14"},
            {"country", "United Arab Emirates"}
        }

        ' Delete the days key and it's value
        astronaut.Remove("days")

        ' Output the astronaut dictionary
        DisplayKeyValuePairs(astronaut)
    End Sub


    ' Display the key-value pairs from the given astronaut dictionary
    Sub DisplayKeyValuePairs(ByVal astronaut As Dictionary(Of String, String))
        Console.WriteLine("Astronaut dictionary:")

        ' Repeat for each key-value pair in the dictionary
        For Each kvp In astronaut
            Dim key = kvp.Key
            Dim value = kvp.Value
            Console.WriteLine($"Key: {key}, value: {value}")
        Next
    End Sub

End Module
