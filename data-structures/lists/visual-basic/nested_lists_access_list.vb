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
        Dim allAstronauts As New List(Of List(Of String))({
            New List(Of String)({"ISS", "Sergey Prokopyev", "176"}),
            New List(Of String)({"ISS", "Dmitry Petelin", "176"}),
            New List(Of String)({"ISS", "Frank Rubio", "176"}),
            New List(Of String)({"Tiangong", "Fei Junlong", "112"}),
            New List(Of String)({"Tiangong", "Deng Qingming", "107"}),
            New List(Of String)({"Tiangong", "Zhang Lu", "107"}),
            New List(Of String)({"ISS", "Stephen Bowen", "54"}),
            New List(Of String)({"ISS", "Warren Hoburg", "14"}),
            New List(Of String)({"ISS", "Sultan Al Neyadi", "14"}),
            New List(Of String)({"ISS", "Andrey Fedyaev", "14"})
        })

        ' Retrieve the first astronaut list at index 0
        Dim astronaut As List(Of String) = allAstronauts(0)

        ' Output the astronaut's spacecraft and name
        Dim spacecraft = astronaut(0)
        Dim name = astronaut(1)
        Console.WriteLine($"Astronaut {name} is on the {spacecraft}")
    End Sub
End Module