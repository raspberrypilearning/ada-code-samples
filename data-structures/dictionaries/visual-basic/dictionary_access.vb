' Raspberry Pi Foundation
' Developed as part of Ada Computer Science
' Usage licensed under CC BY-NC-SA 4.0
' Note: This file is designed to be copied out and compiled on your machine.
' To run this file you need to:
' 1. Copy the contents
' 2. Paste them into the Visual Basic IDE of your choice (Visual Studio, for example)
' 3. Compile the program
' 4. Run the program

Imports System.Collections.Generic

Module Program
    ' The Main method is the entry point for all C# programs
    Sub Main()
        ' Declare and initialise the astronaut dictionary
        Dim astronaut As Dictionary(Of String, String) = New Dictionary(Of String, String)() From {
            {"craft", "ISS"},
            {"name", "Sultan Al Neyadi"},
            {"days", "14"}
        }

        ' Output the name and spacecraft
        Dim name = astronaut("name")
        Dim spacecraft = astronaut("craft")
        Console.WriteLine($"Astronaut {name} is on the {spacecraft}")
    End Sub
End Module
