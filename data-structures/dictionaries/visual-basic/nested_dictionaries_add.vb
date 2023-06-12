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

        ' Ask the user to input the new astronaut's details
        Console.WriteLine("Enter the astronaut's full name:")
        Dim name As String = Console.ReadLine()
        Console.WriteLine("Enter the name of the spacecraft:")
        Dim spacecraft As String = Console.ReadLine()
        Console.WriteLine("Enter the current number of days in space:")
        Dim days As String = Console.ReadLine()

        ' Add the new astronaut to the list
        AddNewAstronaut(astronautsByName, name, spacecraft, days)

        ' Output the details of the new astronaut
        Console.WriteLine($"Astronaut name: {name}")
        Dim astronaut = astronautsByName(name)
        DisplayKeyValuePairs(astronaut)
    End Sub


    ' Add a new astronaut dictionary to the nested dictionary
    Sub AddNewAstronaut(ByVal astronautsByName As Dictionary(Of String, Dictionary(Of String, String)), ByVal givenName As String, ByVal givenSpacecraft As String, ByVal givenDays As String)

        ' Create a new dictionary for the astronaut
        Dim newAstronaut = New Dictionary(Of String, String)() From {
                {"craft", givenSpacecraft},
                {"days", givenDays}
            }

        ' Add the new astronaut dictionary to the nested dictionary
        astronautsByName(givenName) = newAstronaut
    End Sub


    ' Display the key-value pairs from the given astronaut dictionary
    Sub DisplayKeyValuePairs(ByVal astronaut As Dictionary(Of String, String))
        Console.WriteLine("Astronaut dictionary:")

        ' Repeat for each key-value pair in the dictionary
        For Each kvp In astronaut
            Dim key = kvp.Key
            Dim value = kvp.Value
            Console.WriteLine($"Key: {key}, value: {value}")
        Next
    End Sub


End Module
