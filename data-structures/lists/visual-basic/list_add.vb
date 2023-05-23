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
            "Sergey Prokopyev",
            "Frank Rubio",
            "Stephen Bowen"
        })

        ' Ask the user to input the astronaut's country of origin
        Console.WriteLine("Enter the astronaut's country of origin:")
        Dim country As String = Console.ReadLine

        ' Add the country to the end of the list
        astronauts.Add(country)

        ' Output the astronaut list
        DisplayAstronauts(astronauts)
    End Sub

    ' Display the values from the given astronaut list
    Sub DisplayAstronauts(ByVal astronauts As List(Of String))
        Console.WriteLine(vbLf & "Astronauts:")

        ' Repeat for each value in the list
        For Each value As String In astronauts
            Console.WriteLine(value)
        Next
    End Sub
End Module