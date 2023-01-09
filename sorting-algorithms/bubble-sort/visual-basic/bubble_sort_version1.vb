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
        Dim testItems As Integer() = {43, 21, 2, 50, 3, 80, 35, 7, 64} 
        Console.WriteLine("### Bubble sort version 1 (for loop) ###")
        Console.WriteLine("[{0}]", String.Join(", ", testItems))  ' Display array of test data
        BubbleSortVersion1(testItems)
    End Sub

    Sub BubbleSortVersion1(ByVal items As Integer())
        Dim numItems As Integer = items.Length

        For passNum As Integer = 1 To numItems - 1

            For index As Integer = 0 To numItems - 1 - 1

                If items(index) > items(index + 1) Then
                    Dim temp As Integer = items(index)
                    items(index) = items(index + 1)
                    items(index + 1) = temp
                End If
            Next

            Console.WriteLine("[{0}]", String.Join(", ", items))
        Next
    End Sub

End Module
