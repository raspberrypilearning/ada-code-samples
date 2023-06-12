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
            {"days", "14"}
        }

        ' Update the days in space of the astronaut
        astronaut("days") = "18"

        ' Output the updated number of days
        Dim newDays = astronaut("days")
        Console.WriteLine($"The days in space has been changed to {newDays}")
    End Sub

End Module
