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
        ' Output the details of each astronaut in the dictionary
        Console.WriteLine("Details of each astronaut:")
        DisplayAllAstronauts(astronautsByName)
    End Sub


    ' Display the key-value pairs of each astronaut in the nested dictionary
    Sub DisplayAllAstronauts(
        ByVal astronautsByName As Dictionary(Of String, Dictionary(Of String, String)))

        ' Repeat for each astronaut in the outer dictionary
        For Each kvp In astronautsByName
            Dim name = kvp.Key
            Dim astronaut = kvp.Value
            Console.WriteLine(name)

            ' Repeat for each key-value pair in the inner dictionary
            For Each innerKvp In astronaut
                Dim key = innerKvp.Key
                Dim value = innerKvp.Value
                Console.WriteLine($"Key: {key}, value: {value}")
            Next
            Console.WriteLine() ' Print an extra line after each astronaut
        Next
    End Sub


End Module
