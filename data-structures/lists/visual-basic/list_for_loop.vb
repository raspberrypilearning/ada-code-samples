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
        ' Declare and initialise the astronaut list
        Dim astronauts As New List(Of String)({
            "Frank Rubio",
            "Stephen Bowen",
            "Sultan Al Neyadi"
        })

        ' Output the astronaut list
        DisplayAstronauts(astronauts)
    End Sub

    ' Display the values from the given astronaut list
    Sub DisplayAstronauts(ByVal astronauts As List(Of String))
        Console.WriteLine("Astronauts:")

        ' Repeat for all the values in the list using the index i
        Dim numAstronauts As Integer = astronauts.Count
        For i = 0 To numAstronauts - 1
            Console.WriteLine($"Index {i} contains the value {astronauts(i)}")
        Next

        Console.WriteLine($"There are {numAstronauts} astronauts in the list")
    End Sub
End Module