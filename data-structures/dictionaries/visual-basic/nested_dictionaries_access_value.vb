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
                {"craft", "Tiangong"},
                {"days", "112"}}
            },
            {"Deng Qingming", New Dictionary(Of String, String) From {
                {"craft", "Tiangong"},
                {"days", "107"}}
            },
            {"Zhang Lu", New Dictionary(Of String, String) From {
                {"craft", "Tiangong"},
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

        ' Output the astronaut's spacecraft and days
        Dim spacecraft = astronautsByName("Fei Junlong")("craft")
        Dim days = astronautsByName("Fei Junlong")("days")
        Console.WriteLine($"Fei Junlong has spent {days} days on the {spacecraft}")
    End Sub


End Module
