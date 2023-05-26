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

        ' Set the position to be the first astronaut at index 0
        Dim position = 0

        ' Ask the user for the new number of days in space
        Console.WriteLine("Enter the new number of days:")
        Dim newDays As String = Console.ReadLine()

        ' Update the number of days in space
        UpdateDaysInSpace(allAstronauts, position, newDays)

        ' Output the updated number of days
        Console.WriteLine($"The days has been updated to {allAstronauts(0)(2)}")
    End Sub

    ' Update the number of days in space for an astronaut
    Sub UpdateDaysInSpace(ByVal allAstronauts As List(Of List(Of String)),
        ByVal astronautIndex As Integer, ByVal newDays As String)
        
        allAstronauts(astronautIndex)(DaysIndex) = newDays
    End Sub
End Module