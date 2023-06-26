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

        ' Ask the user for an astronaut's name
        Console.WriteLine("Enter the name of an astronaut to find:")
        Dim nameToFind As String = Console.ReadLine

        ' Check if the name matches a value in the astronaut list
        Dim found As Boolean = CheckNameExists(astronauts, nameToFind)

        ' Output the search results
        If found Then
            Console.WriteLine("Astronaut found!")
        Else
            Console.WriteLine("Astronaut not found in this data set")
        End If
    End Sub

    ' Return true if the search value is found in the list
    Function CheckNameExists(ByVal astronauts As List(Of String), ByVal searchName As String) As Boolean
        Dim i As Integer = 0
        Dim isFound As Boolean = False

        ' Repeat while the search name has not been found
        While (Not isFound AndAlso (i < astronauts.Count))
            ' Check if the current name equals the search name
            If astronauts(i).Equals(searchName) Then
                isFound = True
            End If
            i = i + 1 ' Increment the counter
        End While

        Return isFound
    End Function
End Module
