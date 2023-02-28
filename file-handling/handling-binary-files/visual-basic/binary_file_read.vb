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
        ReadBinaryFile()
    End Sub

    Sub ReadBinaryFile()
        Dim player_stats As Dictionary(Of String, Double) = New Dictionary(Of String, Double)()
        Dim filename As String = "treasure.game"

        Using stream = IO.File.Open(filename, IO.FileMode.Open)

            Using binaryReader = New System.IO.BinaryReader(stream)

                While binaryReader.BaseStream.Position <> binaryReader.BaseStream.Length
                    Dim key = binaryReader.ReadString()
                    Dim value = binaryReader.ReadDouble()
                    player_stats.Add(key, value)
                End While
            End Using
        End Using

        Console.WriteLine("Output dictionary read from binary file")

        For Each kvp In player_stats 'For each key-value pair (kvp)
            Console.WriteLine("Key: {0}, Value: {1}", kvp.Key, kvp.Value)
        Next
    End Sub

End Module
