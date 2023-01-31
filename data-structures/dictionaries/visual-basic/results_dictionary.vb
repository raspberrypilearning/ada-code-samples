' Raspberry Pi Foundation
' Usage licensed under CC BY-SA 4
' Note: This file is designed to be copied out and compiled on your machine.
' To run this file you need to:
' 1. Copy the contents
' 2. Paste them into the Visual Basic IDE of your choice (Visual Studio, for example)
' 3. Compile the program
' 4. Run the program


Module Program

    ' The Main subroutine is the default entry point for a VB program
    Sub Main()
        Dim results As Dictionary(Of String, Integer) = New Dictionary(Of String, Integer)() From {
        {"Detra", 17},
        {"Nova", 84},
        {"Charlie", 22},
        {"Hwa", 75},
        {"Roxann", 92},
        {"Elsa", 29}}
        Dim score As Integer = results("Charlie")
        Console.WriteLine($"Charlie's score is {score}")
        
        'Add new entry to dictionary
        results("Bob") = 78
        Console.WriteLine($"Bob has been added with score {results("Bob")}")

        'Update an entry in the dictionary
        results("Hwa") = 71
        Console.WriteLine($"Hwa's new score is {results("Hwa")}")

        'Delete an entry from the dictionary
        results.Remove("Elsa")
        Console.WriteLine("Elsa has been deleted" & vbLf)
        
        'Display the entire dictionary
        For Each kvp As KeyValuePair(Of String, Integer) In results
            Dim key As String = kvp.Key
            Dim value As Integer = kvp.Value
            Console.WriteLine($"Key: {key}  Value: {value}")
        Next
    
    End Sub


End Module
