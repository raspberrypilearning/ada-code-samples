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
        Dim text As String = "aaaabbbccdddeee" ' First piece of test data
        Console.WriteLine(text)
        Console.WriteLine(RLE(text))

        text = "Bobby"
        Console.WriteLine(text)
        Console.WriteLine(RLE(text))

        text = "a"
        Console.WriteLine(text)
        Console.WriteLine(RLE(text))

        text = "aaaaaa"
        Console.WriteLine(text)
        Console.WriteLine(RLE(text))

        text = "aaaae"
        Console.WriteLine(text)
        Console.WriteLine(RLE(text))

        text = "aeeeee"
        Console.WriteLine(text)
        Console.WriteLine(RLE(text))

        Console.WriteLine("Finished")
        Console.ReadLine()
    End Sub

    Function RLE(ByVal textString As String) As String
        Dim currentToken As Char = textString(0)
        Dim compressed As String = currentToken.ToString()
        Dim counter As Integer = 1

        For i As Integer = 1 To textString.Length - 1
            Dim nextToken As Char = textString(i)

            If nextToken <> currentToken Then
                compressed = compressed & counter.ToString() & nextToken
                counter = 1
            Else
                counter = counter + 1
            End If

            currentToken = nextToken
        Next

        compressed = compressed & counter.ToString()
        Return compressed
    End Function

End Module

