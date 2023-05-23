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
    ' Index values of each astronaut
    Public Const CraftIndex As Integer = 0
    Public Const NameIndex As Integer = 1
    Public Const DaysIndex As Integer = 2

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

        ' Find all the astronauts on a spacecraft
        Console.WriteLine("Get a list of all astronauts that are on a specific spacecraft")
        Console.WriteLine("Enter the spacecraft name:")
        Dim spacecraft As String = Console.ReadLine()
        Dim foundAstronauts As List(Of List(Of String)) = GetAstronautsBySpacecraft(allAstronauts, spacecraft)

        ' Output the search results
        If foundAstronauts.Count = 0 Then
            Console.WriteLine(vbLf & $"No astronauts found in the spacecraft {spacecraft}")
        Else
            Console.WriteLine(vbLf & "Astronauts found:")
            DisplayAllAstronauts(foundAstronauts)
        End If
    End Sub

    ' Return a list of astronauts that are on a given spacecraft
    Function GetAstronautsBySpacecraft(ByVal allAstronauts As List(Of List(Of String)), ByVal givenSpacecraft As String) As List(Of List(Of String))
        ' Declare a list to store the found astronauts in
        Dim foundList As New List(Of List(Of String))()

        ' Repeat for all astronauts in the outer list using the index i
        For i = 0 To allAstronauts.Count - 1
            ' Check if the astronaut is in the spacecraft
            If givenSpacecraft.Equals(allAstronauts(i)(CraftIndex)) Then
                foundList.Add(allAstronauts(i))
            End If
        Next

        Return foundList
    End Function


    ' Display the values of each astronaut in the given list
    Sub DisplayAllAstronauts(ByVal allAstronauts As List(Of List(Of String)))
        ' Repeat for each astronaut in the outer list
        For Each astronaut In allAstronauts
            ' Repeat for each value in the inner list
            For Each value In astronaut
                Console.Write($"{value}  ") ' Do not print new line
            Next
            Console.WriteLine() ' Print a new line after each astronaut
        Next
    End Sub
End Module