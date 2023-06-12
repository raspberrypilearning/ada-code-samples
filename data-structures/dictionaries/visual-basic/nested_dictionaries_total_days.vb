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
        ' Declare and initialise the nested dictionary of astronauts
        Dim astronautsByName = New Dictionary(Of String, Dictionary(Of String, String))() From {
            {"Sergey Prokopyev", New Dictionary(Of String, String) From {
                {"craft", "ISS"},
                {"days", "176"}}
            },
            {"Dmitry Petelin", New Dictionary(Of String, String) From {
                {"craft", "ISS"},
                {"days", "176"}}
            },
            {"Frank Rubio", New Dictionary(Of String, String) From {
                {"craft", "ISS"},
                {"days", "176"}}
            },
            {"Fei Junlong", New Dictionary(Of String, String) From {
                {"craft", "Shenzhou 15"},
                {"days", "112"}}
            },
            {"Deng Qingming", New Dictionary(Of String, String) From {
                {"craft", "Shenzhou 15"},
                {"days", "107"}}
            },
            {"Zhang Lu", New Dictionary(Of String, String) From {
                {"craft", "Shenzhou 15"},
                {"days", "107"}}
            },
            {"Stephen Bowen", New Dictionary(Of String, String) From {
                {"craft", "ISS"},
                {"days", "54"}}
            },
            {"Warren Hoburg", New Dictionary(Of String, String) From {
                {"craft", "ISS"},
                {"days", "14"}}
            },
            {"Sultan Al Neyadi", New Dictionary(Of String, String) From {
                {"craft", "ISS"},
                {"days", "14"}}
            },
            {"Andrey Fedyaev", New Dictionary(Of String, String) From {
                {"craft", "ISS"},
                {"days", "14"}}
            }
        }
        ' Calculate the total number of days in space
        Dim total = CalculateTotalDays(astronautsByName)
        Console.WriteLine($"Total number of days in space: {total}")
    End Sub


    ' Calculate and return the sum of all the astronauts' days in space
    Function CalculateTotalDays(
        ByVal astronautsByName As Dictionary(Of String, Dictionary(Of String, String))) As Integer

        Dim totalDays = 0

        ' Repeat for each astronaut in the outer dictionary
        For Each kvp In astronautsByName
            Dim name = kvp.Key
            Dim astronaut = kvp.Value
            totalDays += Convert.ToInt32(astronaut("days"))
        Next

        Return totalDays
    End Function


End Module
