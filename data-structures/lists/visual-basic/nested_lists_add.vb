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

        ' Ask the user to input the new astronaut's details
        Console.WriteLine("Enter the spacecraft's name:")
        Dim spacecraft As String = Console.ReadLine()

        Console.WriteLine("Enter the astronaut's full name:")
        Dim name As String = Console.ReadLine()

        Console.WriteLine("Enter the current number of days in space:")
        Dim days As String = Console.ReadLine()

        ' Add the new astronaut to the list
        AddNewAstronaut(allAstronauts, spacecraft, name, days)

        ' Output the details of the new astronaut
        Dim lastIndex As Integer = allAstronauts.Count - 1
        Dim astronaut As List(Of String) = allAstronauts(lastIndex)
        DisplayAstronautDetails(astronaut)
    End Sub

    ' Add a new astronaut list to the end of the nested list
    Sub AddNewAstronaut(ByVal allAstronauts As List(Of List(Of String)), ByVal givenSpacecraft As String, ByVal givenName As String, ByVal givenDays As String)

        ' Create a new list for the astronaut
        Dim newAstronaut As New List(Of String)({
            givenSpacecraft,
            givenName,
            givenDays
        })

        ' Add the new astronaut list to the end of the nested list
        allAstronauts.Add(newAstronaut)
    End Sub

    ' Display the values from the given astronaut list
    Sub DisplayAstronautDetails(ByVal astronaut As List(Of String))
        Console.WriteLine(vbLf & "Astronaut details:")

        ' Repeat for each value in the list
        For Each value In astronaut
            Console.WriteLine(value)
        Next
    End Sub
End Module