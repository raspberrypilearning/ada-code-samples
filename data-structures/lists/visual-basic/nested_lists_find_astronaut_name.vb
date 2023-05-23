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

        ' Check if one of the astronaut lists contains a name substring
        Console.WriteLine("Enter the name of an astronaut to find:")
        Dim nameToFind As String = Console.ReadLine()
        Dim position As Integer = FindPositionOfAstronaut(allAstronauts, nameToFind)

        ' Output the search results
        If position = -1 Then
            Console.WriteLine("Astronaut not found in this data set")
        Else
            Console.WriteLine($"Astronaut found at position {position}")
            DisplayAstronautDetails(allAstronauts(position))
        End If
    End Sub

    ' Return the index of the astronaut that contains the search name
    Function FindPositionOfAstronaut(ByVal allAstronauts As List(Of List(Of String)), ByVal searchName As String) As Integer
        Dim i = 0
        Dim foundIndex = -1  ' Return -1 if no astronaut found

        ' Repeat while the astronaut has not been found
        While foundIndex = -1 AndAlso i < allAstronauts.Count
            ' Check if the name value contains the search name substring
            If allAstronauts(i)(NameIndex).Contains(searchName) Then
                ' Stop searching and return the index
                foundIndex = i
            End If
            i += 1 ' Increment the counter
        End While

        Return foundIndex
    End Function

    ' Display the values from the given astronaut list
    Sub DisplayAstronautDetails(ByVal astronaut As List(Of String))
        Console.WriteLine(vbLf & "Astronaut details:")

        ' Repeat for each value in the list
        For Each value In astronaut
            Console.WriteLine(value)
        Next
    End Sub
End Module