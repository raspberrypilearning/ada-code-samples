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
        Dim player_stats = New Dictionary(Of String, Double)() From {
        {"health", 100},
        {"hunger", 10},
        {"money", 20.0},
        {"lives", 3}
    }
        WriteBinaryFile(player_stats)
    End Sub

    Sub WriteBinaryFile(ByVal player_stats As Dictionary(Of String, Double))
        Dim filename As String = "treasure.game"

        Using stream = IO.File.Open(filename, IO.FileMode.Create)

            Using binaryWriter = New System.IO.BinaryWriter(stream)

                For Each item In player_stats
                    binaryWriter.Write(item.Key)
                    binaryWriter.Write(item.Value)
                Next
            End Using
        End Using
    End Sub


End Module
