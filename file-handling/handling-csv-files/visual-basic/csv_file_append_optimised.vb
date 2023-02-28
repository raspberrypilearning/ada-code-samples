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
        Console.WriteLine("Enter the title of the film: ")
        Dim title As String = Console.ReadLine()
        Console.WriteLine("Enter the year the film was made: ")
        Dim year As String = Console.ReadLine()
        Console.WriteLine("Enter the length of the film in minutes: ")
        Dim duration As String = Console.ReadLine()
        Console.WriteLine("Enter the name of the film director: ")
        Dim director As String = Console.ReadLine()
        Console.WriteLine("Enter the average film rating: ")
        Dim rating As String = Console.ReadLine()
        Console.WriteLine("Enter the takings in US$ millions: ")
        Dim takings As String = Console.ReadLine()
        AppendMovieOptimised(title, year, duration, director, rating, takings)
    End Sub

    Sub AppendMovieOptimised(ByVal title As String, ByVal year As String, ByVal duration As String, ByVal director As String, ByVal rating As String, ByVal takings As String)
        Dim fileName As String = "movies.csv"
        Dim newMovie As String = title & "," & year & "," & duration & "," & director & "," & rating & "," & takings

        Using writer As System.IO.StreamWriter = New System.IO.StreamWriter(fileName, True)
            writer.WriteLine(newMovie)
        End Using
    End Sub


End Module
